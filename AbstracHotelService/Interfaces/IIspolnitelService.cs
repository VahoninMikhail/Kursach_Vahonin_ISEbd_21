using AbstracHotelService.BindingModels;
using AbstracHotelService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracHotelService.Interfaces
{
    public interface IIspolnitelService
    {
        List<IspolnitelViewModel> GetList();

        IspolnitelViewModel GetElement(int id);

        void AddElement(IspolnitelBindingModel model);

        void UpdElement(IspolnitelBindingModel model);

        void DelElement(int id);
    }
}
