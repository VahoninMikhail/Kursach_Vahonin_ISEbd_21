using System.Runtime.Serialization;

namespace AbstracHotelService.ViewModels
{
    [DataContract]
    public class UslugaViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string UslugaName { get; set; }

        [DataMember]
        public decimal Price { get; set; }
    }
}
