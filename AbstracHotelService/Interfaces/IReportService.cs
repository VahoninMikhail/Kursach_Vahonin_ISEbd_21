using AbstracHotelService.BindingModels;
using AbstracHotelService.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AbstracHotelService.Interfaces
{
    public interface IReportService
    {
        Task<List<PosetitelPogashenieViewModel>> GetPosetitelPogashenies(ReportBindingModel model);

        Task SendPosetitelPogashenieDoc(PosetitelPogashenieViewModel model, string TempPath);

        Task SendPosetitelAccountXls(ReportBindingModel model);

        Task SendPosetitelAccountDoc(ReportBindingModel model);

        Task SendPosetitelsPogashenies(ReportBindingModel model);

        Task<List<OplataViewModel>> GetPays(ReportBindingModel model);

        Task SendMail(string mailto, string caption, string message, string path = null);

        Task SavePays(ReportBindingModel model);
    }
}
