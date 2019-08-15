using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PRUEBA_NET.Rest.Dominio
{
    [DataContract]
    public class Estudiante
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public int Nota { get; set; }
        [DataMember]
        public int Id { get; set; }
    }
}