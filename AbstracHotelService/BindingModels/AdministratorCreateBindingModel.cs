using AbstracHotelService.App;
using System.Runtime.Serialization;

namespace AbstracHotelService.BindingModels
{
    [DataContract]
    public class AdministratorCreateBindingModel : AppUser
    {
        [DataMember]
        public string AdministratorFIO { get; set; }
    }
}
