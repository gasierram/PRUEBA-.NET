﻿using PRUEBA_NET.Rest.Dominio;
using PRUEBA_NET.Rest.Errores;
using PRUEBA_NET.Rest.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PRUEBA_NET.Rest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Estudiantes" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Estudiantes.svc or Estudiantes.svc.cs at the Solution Explorer and start debugging.
    public class Estudiantes : IEstudiantes
    {
        private EstudianteDAO estudianteDAO = new EstudianteDAO();

        public Estudiante Crear(Estudiante std)
        {
            List<Estudiante> stdExistente = estudianteDAO.ObtenerMaxMin();
            if (stdExistente != null)
            {
                throw new WebFaultException<EstudianteException>(new EstudianteException()
                {
                    Codigo = 101,
                    Descripcion = "Estudiante duplicado"
                }, HttpStatusCode.Conflict);
            }

            return estudianteDAO.Crear(std);
        }

        int IEstudiantes.ConsultarPromedio()
        {
            return estudianteDAO.ConsultarPromedio();
        }

        Estudiante IEstudiantes.Crear(Estudiante std)
        {
            throw new NotImplementedException();
        }

        Estudiante IEstudiantes.InsertarNota(int Id, int Nota)
        {
            return estudianteDAO.InsertarNota(Id, Nota);
        }

        Estudiante IEstudiantes.ObtenerEstudiante()
        {
            throw new NotImplementedException();
        }

        List<Estudiante> IEstudiantes.ObtenerEstudiantes()
        {
            //List<Estudiante> stdExistente = estudianteDAO.ObtenerEstudiantes();
            //if (stdExistente != null)
            //{
            //    throw new WebFaultException<EstudianteException>(new EstudianteException()
            //    {
            //        Codigo = 101,
            //        Descripcion = "Estudiante no existe"
            //    }, HttpStatusCode.Conflict);
            //}

            return estudianteDAO.ObtenerEstudiantes();
        }

        List<Estudiante> IEstudiantes.ObtenerMaxMin()
        {

            return estudianteDAO.ObtenerMaxMin();
        }
    }
}
