using AbstracHotelService.App;
using AbstracHotelService.BindingModels;
using AbstracHotelService.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AbstracHotelService.Interfaces
{
    public interface IAdministratorService
    {
        Task<List<AdministratorViewModel>> GetList();

        Task<AdministratorViewModel> GetElement(int id);

        Task AddElement(AdministratorCreateBindingModel model);

        Task UpdElement(AdministratorBindingModel model);

        Task DelElement(int id);

        Task<AppUser> GetUser(int id);

        Task<AppUser> GetUserByName(string name);

        Task BackUp();
    }
}
