using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Treinamento_App.Models
{
    [DataContract]
   public class Response
    {
        [DataMember]
        public bool erro { get; set; }

        [DataMember]
        public string message { get; set; }


    }
}
