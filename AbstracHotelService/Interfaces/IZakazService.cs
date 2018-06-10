using AbstracHotelService.BindingModels;
using AbstracHotelService.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AbstracHotelService.Interfaces
{
    public interface IZakazService
    {
        Task<List<ZakazViewModel>> GetList();

        Task<List<ZakazViewModel>> GetList(int posetitelId);

        Task<ZakazViewModel> GetElement(int id);

        Task AddElement(ZakazBindingModel model);

        Task UpdElement(ZakazBindingModel model);

        Task DelElement(int id);

        Task CreateOplata(OplataBindingModel model);
    }
}
