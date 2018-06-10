using AbstracHotelService.BindingModels;
using AbstracHotelService.Interfaces;
using AbstracHotelService.ViewModels;
using AbstractHotelModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracHotelService.ImplementationsBD
{
    public class ZakazService : IZakazService
    {
        private readonly AbstractDbContext context;

        public ZakazService(AbstractDbContext context)
        {
            this.context = context;
        }

        public async Task AddElement(ZakazBindingModel model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    var element = new Zakaz
                    {
                        PosetitelId = model.PosetitelId,
                        DateCreate = DateTime.Now,
                        DateImplement = model.PogashenieEnd,
                        ZakazStatus = ZakazStatus.Готов
                    };
                    context.Zakazs.Add(element);
                    await context.SaveChangesAsync();

                    var groupServices = model.UslugaZakazs.GroupBy(rec => rec.UslugaId).Select(rec => new UslugaZakazBindingModel
                    {
                        UslugaId = rec.Key,
                        Count = rec.Sum(r => r.Count)
                    });
                    foreach (var groupService in groupServices)
                    {
                        context.UslugaZakazs.Add(new UslugaZakaz
                        {
                            ZakazId = element.Id,
                            Count = groupService.Count,
                            Price = context.Uslugs.Where(rec => rec.Id == groupService.UslugaId).FirstOrDefault().Price,
                            UslugaId = groupService.UslugaId
                        });

                    }
                    await context.SaveChangesAsync();
                    await Task.Run(() => transaction.Commit());
                }
                catch (Exception)
                {
                    await Task.Run(() => transaction.Rollback());
                    throw;
                }
            }
        }

        public async Task CreateOplata(OplataBindingModel model)
        {
            var serviceOrders = await context.UslugaZakazs.Where(rec => rec.ZakazId == model.ZakazId).Include(rec => rec.Usluga).Select(rec => new UslugaZakazViewModel
            {
                Id = rec.Id,
                UslugaName = rec.Usluga.UslugaName,
                Count = rec.Count,
                Price = rec.Price,
                Total = rec.Count * rec.Price
            }).ToListAsync();
            var remaind = serviceOrders.Select(rec => rec.Total).DefaultIfEmpty(0).Sum() - context.Oplats.Where(rec => rec.ZakazId == model.ZakazId).Select(rec => rec.Summ).DefaultIfEmpty(0).Sum();
            if (remaind > model.Summ)
            {
                var posetitel = await context.Zakazs.Where(rec => rec.Id == model.ZakazId).Select(rec => rec.Posetitel).FirstOrDefaultAsync();
                if (posetitel != null)
                {
                    posetitel.Bonuses += (int)model.Summ - (int)remaind;
                }
                model.Summ = remaind;
            }
            var zakaz = await context.Zakazs.FirstOrDefaultAsync(rec => rec.Id == model.ZakazId);
            if (zakaz != null)
            {
                zakaz.ZakazStatus = (remaind == model.Summ) ? ZakazStatus.Оплачен : ZakazStatus.Принят_на_оплату;
            }
            context.Oplats.Add(new Oplata
            {
                ZakazId = model.ZakazId,
                Summ = model.Summ
            });
            await context.SaveChangesAsync();
        }

        public async Task DelElement(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Zakaz element = await context.Zakazs.FirstOrDefaultAsync(rec => rec.Id == id);
                    if (element != null)
                    {
                        context.UslugaZakazs.RemoveRange(
                                            context.UslugaZakazs.Where(rec => rec.ZakazId == id));
                        context.Zakazs.Remove(element);
                        await context.SaveChangesAsync();
                    }
                    else
                    {
                        throw new Exception("Элемент не найден");
                    }
                    await Task.Run(() => transaction.Commit());
                }
                catch (Exception)
                {
                    await Task.Run(() => transaction.Rollback());
                    throw;
                }
            }
        }

        public async Task<ZakazViewModel> GetElement(int id)
        {
            Zakaz element = await context.Zakazs.FirstOrDefaultAsync(rec => rec.Id == id);
            if (element != null)
            {
                var serviceZakazs = await context.UslugaZakazs.Where(rec => rec.ZakazId == element.Id).Include(rec => rec.Usluga).Select(rec => new UslugaZakazViewModel
                {
                    Id = rec.Id,
                    UslugaName = rec.Usluga.UslugaName,
                    Count = rec.Count,
                    Price = rec.Price,
                    Total = rec.Count * rec.Price
                }).ToListAsync();
                var sum = serviceZakazs.Select(rec => rec.Total).DefaultIfEmpty(0).Sum();
                var paid = context.Oplats.Where(rec => rec.ZakazId == element.Id).Select(rec => rec.Summ).DefaultIfEmpty(0).Sum();
                return new ZakazViewModel
                {
                    Id = element.Id,
                    PosetitelFIO = context.Posetitels.Where(rec => rec.Id == element.PosetitelId).Select(rec => rec.PosetitelFIO).FirstOrDefault(),
                    PosetitelId = element.PosetitelId,
                    DateCreate = element.DateCreate.ToLongDateString(),
                    PogashenieEnd = element.DateCreate.ToLongDateString(),
                    UslugaZakazs = serviceZakazs,
                    ZakazStatus = element.ZakazStatus.ToString(),
                    Sum = sum,
                    Paid = paid,
                    Pogashenie = sum - paid,
                    PogashenieDate = element.DateImplement
                };
            }
            throw new Exception("Элемент не найден");
        }

        public async Task<List<ZakazViewModel>> GetList()
        {
            return await context.Zakazs.Include(rec => rec.Posetitel)
                .Select(rec => new ZakazViewModel
                {
                    Id = rec.Id,
                    PosetitelFIO = rec.Posetitel.PosetitelFIO,
                    Mail = rec.Posetitel.UserName,
                    PosetitelId = rec.PosetitelId,
                    DateCreate = SqlFunctions.DateName("dd", rec.DateCreate) + " " +
                                            SqlFunctions.DateName("mm", rec.DateCreate) + " " +
                                            SqlFunctions.DateName("yyyy", rec.DateCreate),
                    PogashenieEnd = SqlFunctions.DateName("dd", rec.DateImplement) + " " +
                                            SqlFunctions.DateName("mm", rec.DateImplement) + " " +
                                            SqlFunctions.DateName("yyyy", rec.DateImplement),
                    ZakazStatus = rec.ZakazStatus.ToString(),
                    PogashenieDate = rec.DateImplement,
                    //Sum = rec.ServiceOrders.Select(r=>r.Price * r.Count).DefaultIfEmpty(0).Sum(),
                    //Paid = rec.Pays.Select(r=>r.Summ).DefaultIfEmpty(0).Sum(),
                    //Credit = rec.ServiceOrders.Select(r => r.Price * r.Count).DefaultIfEmpty(0).Sum() - rec.Pays.Select(r => r.Summ).DefaultIfEmpty(0).Sum()
                }).ToListAsync();
        }

        public async Task<List<ZakazViewModel>> GetList(int posetitelId)
        {
            return await context.Zakazs.Where(rec => rec.PosetitelId == posetitelId).Include(rec => rec.Posetitel).Include(rec => rec.UslugaZakazs)
                .Select(rec => new ZakazViewModel
                {
                    Id = rec.Id,
                    PosetitelFIO = rec.Posetitel.PosetitelFIO,
                    Mail = rec.Posetitel.UserName,
                    PosetitelId = rec.PosetitelId,
                    DateCreate = SqlFunctions.DateName("dd", rec.DateCreate) + " " +
                                            SqlFunctions.DateName("mm", rec.DateCreate) + " " +
                                            SqlFunctions.DateName("yyyy", rec.DateCreate),
                    PogashenieEnd = SqlFunctions.DateName("dd", rec.DateImplement) + " " +
                                            SqlFunctions.DateName("mm", rec.DateImplement) + " " +
                                            SqlFunctions.DateName("yyyy", rec.DateImplement),
                    ZakazStatus = rec.ZakazStatus.ToString(),
                    PogashenieDate = rec.DateImplement,
                    Sum = rec.UslugaZakazs.Select(r => r.Price * r.Count).DefaultIfEmpty(0).Sum(),
                    Paid = rec.Oplats.Select(r => r.Summ).DefaultIfEmpty(0).Sum(),
                    Pogashenie = rec.UslugaZakazs.Select(r => r.Price * r.Count).DefaultIfEmpty(0).Sum() - rec.Oplats.Select(r => r.Summ).DefaultIfEmpty(0).Sum()
                }).ToListAsync();
        }

        public Task UpdElement(ZakazBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}

