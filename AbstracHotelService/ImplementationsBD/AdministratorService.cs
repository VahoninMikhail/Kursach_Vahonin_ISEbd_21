using AbstracHotelService.App;
using AbstracHotelService.BindingModels;
using AbstracHotelService.Interfaces;
using AbstracHotelService.ViewModels;
using AbstractHotelModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracHotelService.ImplementationsBD
{
    public class AdministratorService : IAdministratorService
    {
        private AbstractDbContext context;

        public AdministratorService(AbstractDbContext context)
        {
            this.context = context;
        }

        public static AdministratorService Create(AbstractDbContext context)
        {
            return new AdministratorService(context);
        }

        public async Task AddElement(AdministratorCreateBindingModel model)
        {
            Administrator element = await context.Administrators.FirstOrDefaultAsync(rec => rec.AdminFIO == model.AdministratorFIO);
            if (element != null)
            {
                throw new Exception("Уже есть админ с таким именем");
            }
            element = await context.Administrators.FirstOrDefaultAsync(rec => rec.UserName == model.UserName);
            if (element != null)
            {
                throw new Exception("Уже есть админ с таким именем пользователя ");
            }
            context.Administrators.Add(new Administrator
            {
                AdminFIO = model.AdministratorFIO,
                UserName = model.UserName,
                Password = model.PasswordHash,
                Zaschita = model.SecurityStamp
            });
            await context.SaveChangesAsync();
        }

        public Task BackUp()
        {
            throw new NotImplementedException();
        }

        public async Task DelElement(int id)
        {
            Administrator element = await context.Administrators.FirstOrDefaultAsync(rec => rec.Id == id);
            if (element != null)
            {
                context.Administrators.Remove(element);
                await context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public async Task<AdministratorViewModel> GetElement(int id)
        {
            Administrator element = await context.Administrators.FirstOrDefaultAsync(rec => rec.Id == id);
            if (element != null)
            {
                return new AdministratorViewModel
                {
                    Id = element.Id,
                    AdministratorFIO = element.AdminFIO,
                    UserName = element.UserName
                };
            }
            throw new Exception("Элемент не найден");
        }

        public async Task<List<AdministratorViewModel>> GetList()
        {
            List<AdministratorViewModel> result = await context.Administrators.Select(rec => new AdministratorViewModel
            {
                Id = rec.Id,
                AdministratorFIO = rec.AdminFIO,
                UserName = rec.UserName
            })
                .ToListAsync();
            return result;
        }

        public async Task<AppUser> GetUser(int id)
        {
            Administrator element = await context.Administrators.FirstOrDefaultAsync(rec => rec.Id == id);
            if (element != null)
            {
                return new AppUser
                {
                    Id = new AppId { Role = ApplicationRole.Administrator, Id = element.Id },
                    UserName = element.UserName,
                    PasswordHash = element.Password,
                    SecurityStamp = element.Zaschita
                };
            }
            return null;
        }

        public async Task<AppUser> GetUserByName(string name)
        {
            Administrator element = await context.Administrators.FirstOrDefaultAsync(rec => rec.UserName.Equals(name));
            if (element != null)
            {
                return new AppUser
                {
                    Id = new AppId { Role = ApplicationRole.Administrator, Id = element.Id },
                    UserName = element.UserName,
                    PasswordHash = element.Password,
                    SecurityStamp = element.Zaschita
                };
            }
            return null;
        }

        public async Task UpdElement(AdministratorBindingModel model)
        {
            Administrator element = await context.Administrators.FirstOrDefaultAsync(rec =>
                                    (rec.AdminFIO == model.AdministratorFIO || rec.UserName == rec.UserName) && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть админ с такими данными");
            }
            element = await context.Administrators.FirstOrDefaultAsync(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.AdminFIO = model.AdministratorFIO;
            element.UserName = model.UserName;
            await context.SaveChangesAsync();
        }

    }
}
