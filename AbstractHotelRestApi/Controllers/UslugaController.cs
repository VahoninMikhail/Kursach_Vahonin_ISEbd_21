using AbstracHotelService.BindingModels;
using AbstracHotelService.Interfaces;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace AbstractHotelRestApi.Controllers
{
    public class UslugaController : ApiController
    {
        private readonly IUslugaService service;

        public UslugaController(IUslugaService service)
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
        public async Task AddElement(UslugaBindingModel model)
        {
            await service.AddElement(model);
        }

        [HttpPut]
        public async Task UpdElement(UslugaBindingModel model)
        {
            await service.UpdElement(model);
        }

        [HttpDelete]
        public async Task DelElement(int id)
        {
            await service.DelElement(id);
        }
    }
}
