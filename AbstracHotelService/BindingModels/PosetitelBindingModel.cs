using System.Runtime.Serialization;

namespace AbstracHotelService.BindingModels
{
    [DataContract]
    public class PosetitelBindingModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string PosetitelFIO { get; set; }

        [DataMember]
        public string UserName { get; set; }
    }
}
