using AbstracHotelService.BindingModels;
using AbstracHotelService.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;

namespace AbstracHotelService.App
{
    public class AppUserStore : UserStore<AppUser, AppRole, AppId, AppUserLogin, AppUserRole, AppUserClaim>
    {
        private readonly IAdministratorService serviceA;

        private readonly IPosetitelService serviceC;

        public AppUserStore(AbstractDbContext context, IAdministratorService serviceA, IPosetitelService serviceC) : base(context)
        {
            this.serviceA = serviceA;
            this.serviceC = serviceC;
        }

        public override Task<AppUser> FindByIdAsync(AppId userId)
        {
            if (userId.Role.Equals(ApplicationRole.Administrator))
            {
                return serviceA.GetUser(userId.Id);
            }
            else if (userId.Role.Equals(ApplicationRole.Posetitel))
            {
                return serviceC.GetUser(userId.Id);
            }
            return null;
        }
        public override Task CreateAsync(AppUser user)
        {

            if (user is AdministratorCreateBindingModel)
            {
                return serviceA.AddElement(user as AdministratorCreateBindingModel);
            }
            else if (user is PosetitelCreateBindingModel)
            {
                return serviceC.AddElement(user as PosetitelCreateBindingModel);
            }
            return null;
        }

        public override Task DeleteAsync(AppUser user)
        {
            if (user.Id.Role.Equals(ApplicationRole.Administrator))
            {
                return serviceA.DelElement(user.Id.Id);
            }
            else if (user.Id.Role.Equals(ApplicationRole.Posetitel))
            {
                return serviceC.DelElement(user.Id.Id);
            }

            return null;
        }

        public async override Task<AppUser> FindByNameAsync(string userName)
        {
            AppUser user = null;

            if ((user = await serviceC.GetUserByName(userName)) != null)
            {
                return user;
            }
            if ((user = await serviceA.GetUserByName(userName)) != null)
            {
                return user;
            }
            return null;
        }
    }
}
