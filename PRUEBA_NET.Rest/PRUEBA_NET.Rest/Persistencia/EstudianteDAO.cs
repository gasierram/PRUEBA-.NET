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
        private string CadenaConexion = "Data Source=DESKTOP-ENV3J53\\SQLEXPRESS;Initial Catalog=PRUEBA_NET;User ID=sa;Password=12345;";
        public Estudiante Crear(Estudiante std)
        {
            Estudiante estudiante = null;
            string sql = "Insert into Estudiante (Nombre, Nota)" +
                "values(@Nombre, @Nota)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@Nombre", estudiante.Nombre));
                    comando.Parameters.Add(new SqlParameter("@Nota", estudiante.Nota));
                    comando.ExecuteNonQuery();
                }
            }
            estudiante = ObtenerMaxMin()[0];
            return estudiante;
        }

        public Estudiante InsertarNota(int Id, int Nota)
        {
            Estudiante estudiante = null;
            string sql = "UPDATE Estudiante SET Nota = @Nota WHERE Id = @Id";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@Id", Id));
                    comando.Parameters.Add(new SqlParameter("@Nota", Nota));
                    comando.ExecuteNonQuery();
                }
            }
            estudiante = ObtenerEstudiante(Id);
            return estudiante;
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            List<Estudiante> encontrados = new List<Estudiante>();
            Estudiante std = null;
            string sql = "select * from Estudiante ";
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
                            while (resultado.Read())
                            {

                                std = new Estudiante()
                                {
                                    Nombre = (string)resultado["Nombre"],
                                    Nota = (int)resultado["Nota"],
                                    Id = (int)resultado["Id"],
                                };
                                encontrados.Add(std);
                            }
                        }
                    }
                }

            }
            return encontrados;
        }

        public Estudiante ObtenerEstudiante(int Id)
        {
            Estudiante std = null;
            string sql = "select * from Estudiante where Id = @Id";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@Id", Id));
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
                        }
                    }
                }

            }
            return std;
        }


        public List<Estudiante> ObtenerMaxMin()
        {
            List<Estudiante> encontrado = new List<Estudiante>();
            Estudiante std = null;
            string sql = "SELECT * FROM Estudiante WHERE  Nota = (SELECT TOP 1 MAX(Nota) from Estudiante)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    //comando.Parameters.Add(new SqlParameter("@Nota", estudiante.Nombre));
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
            string sql2 = "SELECT * FROM Estudiante WHERE  Nota = (SELECT TOP 1 MIN(Nota) from Estudiante)";

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql2, conexion))
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

        public int ConsultarPromedio()
        {
            int nota = new int();
            string sql = "select AVG(Nota) AS 'Promedio Notas' FROM Estudiante";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {

                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            nota = (int)resultado["Promedio Notas"];
                        }
                    }
                }

            }
            return nota;
        }
    }
}