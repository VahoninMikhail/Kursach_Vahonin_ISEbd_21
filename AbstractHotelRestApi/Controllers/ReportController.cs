using AbstracHotelService.BindingModels;
using AbstracHotelService.Interfaces;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Web.Http;

namespace AbstractHotelRestApi.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class ReportController : ApiController
    {
        private readonly IReportService service;

        private readonly string TempPath;

        private readonly string ResourcesPath;

        public ReportController(IReportService service)
        {
            this.service = service;
            TempPath = System.Web.Hosting.HostingEnvironment.MapPath("~/Temp/");
            ResourcesPath = System.Web.Hosting.HostingEnvironment.MapPath("~/Resources/");
        }

        [HttpPost]
        public async Task SendPosetitelAccountDoc(ReportBindingModel model)
        {
            model.FileName = TempPath;
            await service.SendPosetitelAccountDoc(model);
        }

        [HttpPost]
        public async Task SendPosetitelAccountXls(ReportBindingModel model)
        {
            model.FileName = TempPath;
            await service.SendPosetitelAccountXls(model);
        }

        [HttpPost]
        public async Task SendPosetitelsCredits(ReportBindingModel model)
        {
            model.FileName = TempPath;
            await service.SendPosetitelsPogashenies(model);
        }

        [HttpPost]
        public async Task<IHttpActionResult> GetOplats(ReportBindingModel model)
        {
            var list = await service.GetPays(model);
            if (list == null)
            {
                InternalServerError(new Exception("Нет данных"));
            }
            return Ok(list);
        }

        [HttpPost]
        public async Task SaveOplats(ReportBindingModel model)
        {
            model.FontPath = ResourcesPath + "TIMCYR.TTF";
            if (!File.Exists(model.FontPath))
            {
                File.WriteAllBytes(model.FontPath, Properties.Resources.TIMCYR);
            }
            await service.SavePays(model);
        }

    }
}
