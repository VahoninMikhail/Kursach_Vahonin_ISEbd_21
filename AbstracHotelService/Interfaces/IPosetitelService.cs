using AbstracHotelService.App;
using AbstracHotelService.BindingModels;
using AbstracHotelService.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AbstracHotelService.Interfaces
{
    public interface IPosetitelService
    {
        Task<List<PosetitelViewModel>> GetList();

        Task<PosetitelViewModel> GetElement(int id);

        Task AddElement(PosetitelCreateBindingModel model);

        Task UpdElement(PosetitelBindingModel model);

        Task DelElement(int id);

        Task<AppUser> GetUser(int id);

        Task<AppUser> GetUserByName(string name);

        Task RaiseBonuses(RepaymentBindingModel model);

        Task DecreaseBonuses(RepaymentBindingModel model);

        Task PenetrateClients();
    }
}
