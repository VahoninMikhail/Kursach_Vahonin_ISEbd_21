﻿using System.Runtime.Serialization;

namespace AbstractHotelView
{
    [DataContract]
    public class TokenResponse
    {
        [DataMember]
        public string Access_token { get; set; }

        [DataMember]
        public string Token_type { get; set; }

        [DataMember]
        public string UserName { get; set; }
    }
}
