using System.Runtime.Serialization;

namespace AbstracHotelService.BindingModels
{
    [DataContract]
    public class AdministratorBindingModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string AdministratorFIO { get; set; }

        [DataMember]
        public string UserName { get; set; }
    }
}
