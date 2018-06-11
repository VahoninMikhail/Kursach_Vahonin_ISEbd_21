using System.Runtime.Serialization;

namespace AbstracHotelService.ViewModels
{
    [DataContract]
    public class UslugaZakazViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int UslugaId { get; set; }

        [DataMember]
        public string UslugaName { get; set; }

        [DataMember]
        public int Count { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public decimal Total { get; set; }
    }
}
