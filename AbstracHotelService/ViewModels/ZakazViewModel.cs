using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AbstracHotelService.ViewModels
{
    [DataContract]
    public class ZakazViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PosetitelId { get; set; }

        [DataMember]
        public string PosetitelFIO { get; set; }

        [DataMember]
        public string Mail { get; set; }

        [DataMember]
        public string ZakazStatus { get; set; }

        [DataMember]
        public string DateCreate { get; set; }

        [DataMember]
        public string PogashenieEnd { get; set; }

        [DataMember]
        public decimal Sum { get; set; }

        [DataMember]
        public decimal Paid { get; set; }

        [DataMember]
        public decimal Pogashenie { get; set; }

        [DataMember]
        public List<UslugaZakazViewModel> UslugaZakazs { get; set; }

        [DataMember]
        public DateTime PogashenieDate { get; set; }
    }
}
