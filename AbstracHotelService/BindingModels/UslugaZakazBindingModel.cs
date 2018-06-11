using System.Runtime.Serialization;

namespace AbstracHotelService.BindingModels
{
    [DataContract]
    public class UslugaZakazBindingModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int UslugaId { get; set; }

        [DataMember]
        public int Count { get; set; }
    }
}
