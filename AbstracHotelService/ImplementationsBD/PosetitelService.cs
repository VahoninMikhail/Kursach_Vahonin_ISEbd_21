using AbstracHotelService.App;
using AbstracHotelService.BindingModels;
using AbstracHotelService.Interfaces;
using AbstracHotelService.ViewModels;
using AbstractHotelModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbstracHotelService.ImplementationsBD
{
    public class PosetitelService : IPosetitelService
    {
        private AbstractDbContext context;

        public PosetitelService(AbstractDbContext context)
        {
            this.context = context;
        }

        public static PosetitelService Create(AbstractDbContext context)
        {
            return new PosetitelService(context);
        }

        public async Task AddElement(PosetitelCreateBindingModel model)
        {
            Posetitel element = await context.Posetitels.FirstOrDefaultAsync(rec => rec.PosetitelFIO == model.PosetitelFIO);
            if (element != null)
            {
                throw new Exception("Already have a client with such a name");
            }
            element = await context.Posetitels.FirstOrDefaultAsync(rec => rec.UserName == model.UserName);
            if (element != null)
            {
                throw new Exception("Already have a client with such a email");
            }
            context.Posetitels.Add(new Posetitel
            {
                PosetitelFIO = model.PosetitelFIO,
                UserName = model.UserName,
                Bonuses = 0,
                Password = model.PasswordHash,
                Zaschita = model.SecurityStamp,
                Active = true
            });
            await context.SaveChangesAsync();
        }

        public async Task DecreaseBonuses(RepaymentBindingModel model)
        {
            Posetitel element = await context.Posetitels.FirstOrDefaultAsync(rec => rec.Id == model.PosetitelId);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Bonuses -= model.Fine;
            await context.SaveChangesAsync();
        }

        public async Task DelElement(int id)
        {
            Posetitel element = await context.Posetitels.FirstOrDefaultAsync(rec => rec.Id == id);
            if (element != null)
            {
                context.Posetitels.Remove(element);
                await context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public async Task<PosetitelViewModel> GetElement(int id)
        {
            Posetitel element = await context.Posetitels.FirstOrDefaultAsync(rec => rec.Id == id);
            if (element != null)
            {
                return new PosetitelViewModel
                {
                    Id = element.Id,
                    PosetitelFIO = element.PosetitelFIO,
                    UserName = element.UserName,
                    Bonuses = element.Bonuses,
                    Active = (element.Active) ? "Active" : "Locked"
                };
            }
            throw new Exception("Element not found");
        }

        public async Task<List<PosetitelViewModel>> GetList()
        {
            List<PosetitelViewModel> result = await context.Posetitels.Select(rec => new PosetitelViewModel
            {
                Id = rec.Id,
                PosetitelFIO = rec.PosetitelFIO,
                UserName = rec.UserName,
                Bonuses = rec.Bonuses,
                Active = (rec.Active) ? "Active" : "Locked"
            })
                .ToListAsync();
            return result;
        }

        public async Task PenetrateClients()
        {
            DateTime now = DateTime.Now;
            var posetitels = await context.Zakazs.Where(rec => rec.DateImplement < now && rec.ZakazStatus != ZakazStatus.Оплачен).Include(rec => rec.Posetitel)
                .Select(rec => rec.Posetitel).Distinct().ToListAsync();
            await StartPenetrating(posetitels);
            await context.SaveChangesAsync();
        }

        private Task StartPenetrating(List<Posetitel> posetitels)
        {
            CountdownEvent countdown = new CountdownEvent(1);
            foreach (var posetitel in posetitels)
            {
                countdown.AddCount();

                Task.Run(() =>
                {
                    posetitel.Active = false;
                    countdown.Signal();
                });
            }
            countdown.Signal();

            countdown.Wait();
            return Task.Run(() => true);
        }

        public async Task RaiseBonuses(RepaymentBindingModel model)
        {
            Posetitel element = await context.Posetitels.FirstOrDefaultAsync(rec => rec.Id == model.PosetitelId);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Bonuses += model.Calculation;
            await context.SaveChangesAsync();
        }

        public async Task UpdElement(PosetitelBindingModel model)
        {
            Posetitel element = await context.Posetitels.FirstOrDefaultAsync(rec =>
                                    (rec.PosetitelFIO == model.PosetitelFIO || rec.UserName == model.UserName) && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть посетитель с такими данными");
            }
            element = await context.Posetitels.FirstOrDefaultAsync(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.PosetitelFIO = model.PosetitelFIO;
            element.UserName = model.UserName;
            await context.SaveChangesAsync();
        }

        public async Task<AppUser> GetUser(int id)
        {
            Posetitel element = await context.Posetitels.FirstOrDefaultAsync(rec => rec.Id == id);
            if (element != null)
            {
                return new AppUser
                {
                    Id = new AppId { Role = ApplicationRole.Posetitel, Id = element.Id },
                    UserName = element.UserName,
                    PasswordHash = element.Password,
                    SecurityStamp = element.Zaschita
                };
            }
            return null;
        }

        public async Task<AppUser> GetUserByName(string name)
        {
            Posetitel element = await context.Posetitels.FirstOrDefaultAsync(rec => rec.UserName.Equals(name));
            if (element != null)
            {
                return new AppUser
                {
                    Id = new AppId { Role = ApplicationRole.Posetitel, Id = element.Id },
                    UserName = element.UserName,
                    PasswordHash = element.Password,
                    SecurityStamp = element.Zaschita
                };
            }
            return null;
        }
    }
}
