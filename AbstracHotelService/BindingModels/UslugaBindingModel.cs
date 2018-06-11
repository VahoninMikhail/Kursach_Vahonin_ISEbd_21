using System.Runtime.Serialization;

namespace AbstracHotelService.BindingModels
{
    [DataContract]
    public class UslugaBindingModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string UslugaName { get; set; }

        [DataMember]
        public decimal Price { get; set; }
    }
}
