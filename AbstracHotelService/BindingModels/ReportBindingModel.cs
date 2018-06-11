using System;
using System.Runtime.Serialization;

namespace AbstracHotelService.BindingModels
{
    [DataContract]
    public class ReportBindingModel
    {
        [DataMember]
        public int ZakazId { get; set; }

        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public string FontPath { get; set; }

        [DataMember]
        public DateTime DateFrom { get; set; }

        [DataMember]
        public DateTime DateTo { get; set; }
    }
}
