using AbstracHotelService.BindingModels;
using AbstracHotelService.Interfaces;
using AbstracHotelService.ViewModels;
using AbstractHotelModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracHotelService.ImplementationsBD
{
    public class PosetitelServiceBD : IPosetitelService
    {
        private AbstractDbContext context;

        public PosetitelServiceBD(AbstractDbContext context)
        {
            this.context = context;
        }

        public List<PosetitelViewModel> GetList()
        {
            List<PosetitelViewModel> result = context.Posetitels
                .Select(rec => new PosetitelViewModel
                {
                    Id = rec.Id,
                    PosetitelFIO = rec.PosetitelFIO
                })
                .ToList();
            return result;
        }

        public PosetitelViewModel GetElement(int id)
        {
            Posetitel element = context.Posetitels.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new PosetitelViewModel
                {
                    Id = element.Id,
                    PosetitelFIO = element.PosetitelFIO
                };
            }
            throw new Exception("Элемент не найден");
        }

        public void AddElement(PosetitelBindingModel model)
        {
            Posetitel element = context.Posetitels.FirstOrDefault(rec => rec.PosetitelFIO == model.PosetitelFIO);
            if (element != null)
            {
                throw new Exception("Уже есть посетитель с таким ФИО");
            }
            context.Posetitels.Add(new Posetitel
            {
                PosetitelFIO = model.PosetitelFIO
            });
            context.SaveChanges();
        }

        public void UpdElement(PosetitelBindingModel model)
        {
            Posetitel element = context.Posetitels.FirstOrDefault(rec =>
                                    rec.PosetitelFIO == model.PosetitelFIO && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть посетитель с таким ФИО");
            }
            element = context.Posetitels.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.PosetitelFIO = model.PosetitelFIO;
            context.SaveChanges();
        }

        public void DelElement(int id)
        {
            Posetitel element = context.Posetitels.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Posetitels.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
