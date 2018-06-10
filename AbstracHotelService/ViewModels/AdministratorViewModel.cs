using System.Runtime.Serialization;

namespace AbstracHotelService.ViewModels
{
    [DataContract]
    public class AdministratorViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string AdministratorFIO { get; set; }

        [DataMember]
        public string UserName { get; set; }
    }
}
