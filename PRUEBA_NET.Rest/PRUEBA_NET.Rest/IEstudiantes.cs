using PRUEBA_NET.Rest.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PRUEBA_NET.Rest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEstudiantes" in both code and config file together.
    [ServiceContract]
    public interface IEstudiantes
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Estudiantes", ResponseFormat = WebMessageFormat.Json)]
        Estudiante CrearActividad(Estudiante std);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Notas", ResponseFormat = WebMessageFormat.Json)]
        List<Estudiante> ObtenerMaxMin();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Promedios", ResponseFormat = WebMessageFormat.Json)]
        List<Estudiante> ConsultarPromedio();
    }
}
