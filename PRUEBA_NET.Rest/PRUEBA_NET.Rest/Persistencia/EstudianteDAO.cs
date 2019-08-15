using PRUEBA_NET.Rest.Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PRUEBA_NET.Rest.Persistencia
{
    public class EstudianteDAO
    {
        private string CadenaConexion = "Data Source=(local);Initial Catalog=PRUEBA_NET;User ID=alejo;Password=12345;";
        public Estudiante Crear(Estudiante std)
        {
            Estudiante estudiante = null;
            string sql = "Insert into estudiante (Nombre, Nota, Id) " +
                "values(@Nombre, @Nota, @Id)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@Nombre", estudiante.Nombre));
                    comando.Parameters.Add(new SqlParameter("@Nota", estudiante.Nota));
                    comando.Parameters.Add(new SqlParameter("@Id", estudiante.Id));
                    comando.ExecuteNonQuery();
                }
            }
            estudiante = ObtenerMaxMin()[0];
            return estudiante;
        }
        public List<Estudiante> ObtenerMaxMin()
        {
            List<Estudiante> encontrado = new List<Estudiante>();
            Estudiante std = null;
            string sql = "select MIN(Nota) AS 'Minimo', MAX(Nota) AS 'Maximo' from Estudiante ";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    //comando.Parameters.Add(new SqlParameter("@Id", Id));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {

                            std = new Estudiante()
                            {
                                Nombre = (string)resultado["Nombre"],
                                Nota = (int)resultado["Nota"],
                                Id = (int)resultado["Id"],
                            };
                            encontrado.Add(std);
                        }
                    }
                }

            }
            return encontrado;
        }

        public List<Estudiante> ConsultarPromedio()
        {
            List<Estudiante> promedios = new List<Estudiante>();
            Estudiante estudiante = null;
            string sql = "select AVG(Nota) AS 'Promedio Notas', FROM Estudiante";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {

                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            estudiante = new Estudiante()
                            {
                                Nombre = (string)resultado["Nombre"],
                                Nota = (int)resultado["Nota"],
                                Id = (int)resultado["Id"],
                            };
                            promedios.Add(estudiante);
                        }
                    }
                }

            }
            return promedios;
        }
    }
}