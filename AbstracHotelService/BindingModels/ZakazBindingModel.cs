using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AbstracHotelService.BindingModels
{
    [DataContract]
    public class ZakazBindingModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PosetitelId { get; set; }

        [DataMember]
        public DateTime PogashenieEnd { get; set; }

        [DataMember]
        public List<UslugaZakazBindingModel> UslugaZakazs { get; set; }
    }
}
