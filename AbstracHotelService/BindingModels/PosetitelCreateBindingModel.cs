using AbstracHotelService.App;
using System.Runtime.Serialization;

namespace AbstracHotelService.BindingModels
{
    [DataContract]
    public class PosetitelCreateBindingModel : AppUser
    {
        [DataMember]
        public string PosetitelFIO { get; set; }
    }
}
