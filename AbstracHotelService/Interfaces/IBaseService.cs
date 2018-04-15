using AbstracHotelService.BindingModels;
using AbstracHotelService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracHotelService.Interfaces
{
    public interface IBaseService
    {
        List<ZakazViewModel> GetList();

        void CreateZakaz(ZakazBindingModel model);

        void TakeZakazInWork(ZakazBindingModel model);

        void FinishZakaz(int id);

        void PayZakaz(int id);

    }
}
