using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebEstudiante
{
    public partial class Prueba_NET : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Estudiantes.EstudiantesClient client = new Estudiantes.EstudiantesClient();
            var std = client.ObtenerMaxMin();
            Nombre.Text = std[0].Nombre;
            Id.Text = std[0].Id.ToString();
            Nota.Text = std[0].Nota.ToString();
        }
    }
}