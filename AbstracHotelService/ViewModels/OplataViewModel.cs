using System.Runtime.Serialization;

namespace AbstracHotelService.ViewModels
{
    [DataContract]
    public class OplataViewModel
    {
        [DataMember]
        public int ZakazId { get; set; }

        [DataMember]
        public string PosetitelFIO { get; set; }

        [DataMember]
        public string DateCreate { get; set; }

        [DataMember]
        public decimal Sum { get; set; }
    }
}
