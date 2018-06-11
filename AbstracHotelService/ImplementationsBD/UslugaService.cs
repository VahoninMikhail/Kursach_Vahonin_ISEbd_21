using AbstracHotelService.BindingModels;
using AbstracHotelService.Interfaces;
using AbstracHotelService.ViewModels;
using AbstractHotelModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracHotelService.ImplementationsBD
{
    public class UslugaService : IUslugaService
    {
        private AbstractDbContext context;

        public UslugaService(AbstractDbContext context)
        {
            this.context = context;
        }

        public async Task AddElement(UslugaBindingModel model)
        {
            Usluga element = await context.Uslugs.FirstOrDefaultAsync(rec => rec.UslugaName == model.UslugaName);
            if (element != null)
            {
                throw new Exception("Already have a employee with such a name");
            }
            context.Uslugs.Add(new Usluga
            {
                UslugaName = model.UslugaName,
                Price = model.Price
            });
            await context.SaveChangesAsync();
        }

        public async Task DelElement(int id)
        {
            Usluga element = await context.Uslugs.FirstOrDefaultAsync(rec => rec.Id == id);
            if (element != null)
            {
                context.Uslugs.Remove(element);
                await context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public async Task<UslugaViewModel> GetElement(int id)
        {
            Usluga element = await context.Uslugs.FirstOrDefaultAsync(rec => rec.Id == id);
            if (element != null)
            {
                return new UslugaViewModel
                {
                    Id = element.Id,
                    UslugaName = element.UslugaName,
                    Price = element.Price
                };
            }
            throw new Exception("Element not found");
        }

        public async Task<List<UslugaViewModel>> GetList()
        {
            List<UslugaViewModel> result = await context.Uslugs.Select(rec => new UslugaViewModel
            {
                Id = rec.Id,
                UslugaName = rec.UslugaName,
                Price = rec.Price
            })
                .ToListAsync();
            return result;
        }

        public async Task UpdElement(UslugaBindingModel model)
        {
            Usluga element = await context.Uslugs.FirstOrDefaultAsync(rec =>
                                    rec.UslugaName == model.UslugaName && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть услуга с таким названием");
            }
            element = await context.Uslugs.FirstOrDefaultAsync(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.UslugaName = model.UslugaName;
            element.Id = model.Id;
            await context.SaveChangesAsync();
        }
    }
}
