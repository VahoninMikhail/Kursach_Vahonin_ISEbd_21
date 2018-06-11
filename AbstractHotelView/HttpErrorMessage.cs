﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHotelView
{
    [DataContract]
    public class HttpErrorMessage
    {
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string ExceptionMessage { get; set; }

        [DataMember]
        public string MessageDetail { get; set; }

        [DataMember]
        public string Error { get; set; }

        [DataMember]
        public string Error_description { get; set; }
    }
}
