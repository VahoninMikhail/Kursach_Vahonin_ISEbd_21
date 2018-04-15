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
    public class UslugaServiceBD : IUslugaService
    {
        private AbstractDbContext context;

        public UslugaServiceBD(AbstractDbContext context)
        {
            this.context = context;
        }

        public List<UslugaViewModel> GetList()
        {
            List<UslugaViewModel> result = context.Uslugs
                .Select(rec => new UslugaViewModel
                {
                    Id = rec.Id,
                    UslugaName = rec.UslugaName,
                    Price = rec.Price,
                })
                .ToList();
            return result;
        }

        public UslugaViewModel GetElement(int id)
        {
            Usluga element = context.Uslugs.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new UslugaViewModel
                {
                    Id = element.Id,
                    UslugaName = element.UslugaName,
                    Price = element.Price,
                };
            }
            throw new Exception("Элемент не найден");
        }

        public void AddElement(UslugaBindingModel model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Usluga element = context.Uslugs.FirstOrDefault(rec => rec.UslugaName == model.UslugaName);
                    if (element != null)
                    {
                        throw new Exception("Уже есть услуга с таким названием");
                    }
                    element = new Usluga
                    {
                        UslugaName = model.UslugaName,
                        Price = model.Price
                    };
                    context.Uslugs.Add(element);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void UpdElement(UslugaBindingModel model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Usluga element = context.Uslugs.FirstOrDefault(rec =>
                                        rec.UslugaName == model.UslugaName && rec.Id != model.Id);
                    if (element != null)
                    {
                        throw new Exception("Уже есть услуга с таким названием");
                    }
                    element = context.Uslugs.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                    element.UslugaName = model.UslugaName;
                    element.Price = model.Price;
                    context.SaveChanges();
                }

                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void DelElement(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Usluga element = context.Uslugs.FirstOrDefault(rec => rec.Id == id);
                    if (element != null)
                    {
                        // удаяем записи при удалении изделия
                        context.Uslugs.Remove(element);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Элемент не найден");
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}


