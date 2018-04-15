using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracHotelService.ViewModels
{
    public class ZakazViewModel
    {
        public int Id { get; set; }

        public int PosetitelId { get; set; }

        public string PosetitelFIO { get; set; }

        public int UslugaId { get; set; }

        public string UslugaName { get; set; }

        public int? IspolnitelId { get; set; }

        public string IspolnitelName { get; set; }

        public int Count { get; set; }

        public decimal Sum { get; set; }

        public string Status { get; set; }

        public string DateCreate { get; set; }

        public string DateImplement { get; set; }
    }
}
