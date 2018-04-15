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
    public class IspolnitelServiceBD : IIspolnitelService
    {
        private AbstractDbContext context;

        public IspolnitelServiceBD(AbstractDbContext context)
        {
            this.context = context;
        }

        public List<IspolnitelViewModel> GetList()
        {
            List<IspolnitelViewModel> result = context.Ispolnitels
                .Select(rec => new IspolnitelViewModel
                {
                    Id = rec.Id,
                    IspolnitelFIO = rec.IspolnitelFIO
                })
                .ToList();
            return result;
        }

        public IspolnitelViewModel GetElement(int id)
        {
            Ispolnitel element = context.Ispolnitels.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new IspolnitelViewModel
                {
                    Id = element.Id,
                    IspolnitelFIO = element.IspolnitelFIO
                };
            }
            throw new Exception("Элемент не найден");
        }

        public void AddElement(IspolnitelBindingModel model)
        {
            Ispolnitel element = context.Ispolnitels.FirstOrDefault(rec => rec.IspolnitelFIO == model.IspolnitelFIO);
            if (element != null)
            {
                throw new Exception("Уже есть исполнитель с таким ФИО");
            }
            context.Ispolnitels.Add(new Ispolnitel
            {
                IspolnitelFIO = model.IspolnitelFIO
            });
            context.SaveChanges();
        }

        public void UpdElement(IspolnitelBindingModel model)
        {
            Ispolnitel element = context.Ispolnitels.FirstOrDefault(rec =>
                                        rec.IspolnitelFIO == model.IspolnitelFIO && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть исполнитель с таким ФИО");
            }
            element = context.Ispolnitels.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.IspolnitelFIO = model.IspolnitelFIO;
            context.SaveChanges();
        }

        public void DelElement(int id)
        {
            Ispolnitel element = context.Ispolnitels.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Ispolnitels.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}

