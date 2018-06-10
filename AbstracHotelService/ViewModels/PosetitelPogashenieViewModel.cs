using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AbstracHotelService.ViewModels
{
    [DataContract]
    public class PosetitelPogashenieViewModel
    {
        [DataMember]
        public int PosetitelId { get; set; }

        [DataMember]
        public string PosetitelFIO { get; set; }

        [DataMember]
        public string Mail { get; set; }

        [DataMember]
        public List<ZakazPogashenieViewModel> ZakazPogashenies { get; set; }
    }
    [DataContract]
    public class ZakazPogashenieViewModel
    {
        [DataMember]
        public int ZakazId { get; set; }

        [DataMember]
        public List<UslugaZakazViewModel> Services { get; set; }

        [DataMember]
        public string DateCreate { get; set; }

        [DataMember]
        public decimal Total { get; set; }

        [DataMember]
        public decimal TotalPaid { get; set; }

        [DataMember]
        public decimal Pogashenie { get; set; }
    }
}
