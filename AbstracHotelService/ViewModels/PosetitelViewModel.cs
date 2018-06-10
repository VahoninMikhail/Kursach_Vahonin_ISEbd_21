using System.Runtime.Serialization;

namespace AbstracHotelService.ViewModels
{
    [DataContract]
    public class PosetitelViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string PosetitelFIO { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public int Bonuses { get; set; }

        [DataMember]
        public string Active { get; set; }
    }
}
