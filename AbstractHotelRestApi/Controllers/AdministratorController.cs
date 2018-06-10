using AbstracHotelService.BindingModels;
using AbstracHotelService.Interfaces;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace AbstractHotelRestApi.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdministratorController : ApiController
    {
        private readonly IAdministratorService service;

        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public AdministratorController(IAdministratorService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetList()
        {
            var list = await service.GetList();
            if (list == null)
            {
                InternalServerError(new Exception("Нет данных"));
            }
            return Ok(list);
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {
            var element = await service.GetElement(id);
            if (element == null)
            {
                InternalServerError(new Exception("Нет данных"));
            }
            return Ok(element);
        }

        [HttpPost]
        public async Task AddElement(AdministratorCreateBindingModel model)
        {
            await UserManager.CreateAsync(model);
        }

        [HttpPut]
        public async Task UpdElement(AdministratorBindingModel model)
        {
            await service.UpdElement(model);
        }

        [HttpDelete]
        public async Task DelElement(int id)
        {
            await service.DelElement(id);
        }

        [HttpPost]
        public async Task BackUp()
        {
            await service.BackUp();
        }
    }
}

