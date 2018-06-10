using AbstracHotelService.BindingModels;
using AbstracHotelService.Interfaces;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace AbstractHotelRestApi.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ZakazController : ApiController
    {
        private readonly IZakazService service;

        public ZakazController(IZakazService service)
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
        [Route("api/Zakaz/GetPosetitelList/{posetitelId}")]
        public async Task<IHttpActionResult> GetClientList(int posetitelId)
        {
            var list = await service.GetList(posetitelId);
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
        public async Task AddElement(ZakazBindingModel model)
        {
            await service.AddElement(model);
        }

        [HttpDelete]
        public async Task DelElement(int id)
        {
            await service.DelElement(id);
        }

        public async Task AddPay(OplataBindingModel model)
        {
            await service.CreateOplata(model);
        }
    }
}

