using AbstracHotelService.BindingModels;
using AbstracHotelService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracHotelService.Interfaces
{
    public interface IPosetitelService
    {
        List<PosetitelViewModel> GetList();

        PosetitelViewModel GetElement(int id);

        void AddElement(PosetitelBindingModel model);

        void UpdElement(PosetitelBindingModel model);

        void DelElement(int id);
    }
}
