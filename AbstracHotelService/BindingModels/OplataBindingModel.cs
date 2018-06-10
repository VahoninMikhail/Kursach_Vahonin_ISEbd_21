using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AbstracHotelService.BindingModels
{
    [DataContract]
    public class OplataBindingModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int ZakazId { get; set; }

        [DataMember]
        public decimal Summ { get; set; }
    }
}