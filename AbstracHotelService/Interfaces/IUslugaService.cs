using AbstracHotelService.BindingModels;
using AbstracHotelService.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AbstracHotelService.Interfaces
{
    public interface IUslugaService
    {
        Task<List<UslugaViewModel>> GetList();

        Task<UslugaViewModel> GetElement(int id);

        Task AddElement(UslugaBindingModel model);

        Task UpdElement(UslugaBindingModel model);

        Task DelElement(int id);
    }
}
