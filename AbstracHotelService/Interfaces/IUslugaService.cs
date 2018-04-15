using AbstracHotelService.BindingModels;
using AbstracHotelService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracHotelService.Interfaces
{
    public interface IUslugaService
    {
        List<UslugaViewModel> GetList();

        UslugaViewModel GetElement(int id);

        void AddElement(UslugaBindingModel model);

        void UpdElement(UslugaBindingModel model);

        void DelElement(int id);
    }
}
