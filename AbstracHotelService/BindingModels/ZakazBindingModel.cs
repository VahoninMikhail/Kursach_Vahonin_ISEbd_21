using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracHotelService.BindingModels
{
    public class ZakazBindingModel
    {
        public int Id { get; set; }

        public int PosetitelId { get; set; }

        public int UslugaId { get; set; }

        public int? IspolnitelId { get; set; }

        public int Count { get; set; }

        public decimal Sum { get; set; }
    }
}
