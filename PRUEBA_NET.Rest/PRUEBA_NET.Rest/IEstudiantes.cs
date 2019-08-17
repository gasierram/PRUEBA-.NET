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
        [WebInvoke(Method = "POST", UriTemplate = "Estudiantes", ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare)]
        Estudiante Crear(Estudiante std);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "InsertarNota", ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Wrapped)]
        Estudiante InsertarNota(int Id, int Nota);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ObtenerEstudiantes", ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare)]
        List<Estudiante> ObtenerEstudiantes();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ObtenerEstudiante", ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare)]
        Estudiante ObtenerEstudiante();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Notas", ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare)]
        List<Estudiante> ObtenerMaxMin();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Promedios", ResponseFormat = WebMessageFormat.Json,
    RequestFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Bare)]
        int ConsultarPromedio();
    }
}
