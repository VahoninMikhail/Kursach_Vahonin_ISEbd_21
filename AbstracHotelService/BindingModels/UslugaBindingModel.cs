using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracHotelService.BindingModels
{
    public class UslugaBindingModel
    {
        public int Id { get; set; }

        public string UslugaName { get; set; }

        public decimal Price { get; set; }
    }
}
