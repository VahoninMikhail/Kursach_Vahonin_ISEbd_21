using System.Runtime.Serialization;

namespace AbstracHotelService.BindingModels
{
    [DataContract]
    public class RepaymentBindingModel
    {
        [DataMember]
        public int PosetitelId { get; set; }

        [DataMember]
        public int Calculation { get; set; }

        [DataMember]
        public int Fine { get; set; }
    }
}
