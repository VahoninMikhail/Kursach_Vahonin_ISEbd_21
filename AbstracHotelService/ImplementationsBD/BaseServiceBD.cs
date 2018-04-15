using AbstracHotelService.Interfaces;
using AbstracHotelService.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AbstracHotelService.BindingModels;
using AbstractHotelModel;

namespace AbstracHotelService.ImplementationsBD
{
    public class BaseServiceBD : IBaseService
    {
        private AbstractDbContext context;

        public BaseServiceBD(AbstractDbContext context)
        {
            this.context = context;
        }

        public List<ZakazViewModel> GetList()
        {
            List<ZakazViewModel> result = context.Zakazs
                .Select(rec => new ZakazViewModel
                {
                    Id = rec.Id,
                    PosetitelId = rec.PosetitelId,
                    UslugaId = rec.UslugaId,
                    IspolnitelId = rec.IspolnitelId,
                    DateCreate = SqlFunctions.DateName("dd", rec.DateCreate) + " " +
                                SqlFunctions.DateName("mm", rec.DateCreate) + " " +
                                SqlFunctions.DateName("yyyy", rec.DateCreate),
                    DateImplement = rec.DateImplement == null ? "" :
                                        SqlFunctions.DateName("dd", rec.DateImplement.Value) + " " +
                                        SqlFunctions.DateName("mm", rec.DateImplement.Value) + " " +
                                        SqlFunctions.DateName("yyyy", rec.DateImplement.Value),
                    Status = rec.Status.ToString(),
                    Count = rec.Count,
                    Sum = rec.Sum,
                    PosetitelFIO = rec.Posetitel.PosetitelFIO,
                    UslugaName = rec.Usluga.UslugaName,
                    IspolnitelName = rec.Ispolnitel.IspolnitelFIO
                })
                .ToList();
            return result;
        }

        public void CreateZakaz(ZakazBindingModel model)
        {
            context.Zakazs.Add(new Zakaz
            {
                PosetitelId = model.PosetitelId,
                UslugaId = model.UslugaId,
                DateCreate = DateTime.Now,
                Count = model.Count,
                Sum = model.Sum,
                Status = ZakazStatus.Принят
            });
            context.SaveChanges();
        }

        public void TakeZakazInWork(ZakazBindingModel model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {

                    Zakaz element = context.Zakazs.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                    element.IspolnitelId = model.IspolnitelId;
                    element.DateImplement = DateTime.Now;
                    element.Status = ZakazStatus.Выполняется;
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void FinishZakaz(int id)
        {
            Zakaz element = context.Zakazs.FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Status = ZakazStatus.Готов;
            context.SaveChanges();
        }

        public void PayZakaz(int id)
        {
            Zakaz element = context.Zakazs.FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Status = ZakazStatus.Оплачен;
            context.SaveChanges();
        }
    }
}
