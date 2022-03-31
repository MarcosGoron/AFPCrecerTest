using AFPCrecer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFPCrecer.BO
{
    public class GenerarCitaBO
    {
        private GenerarCitaDAO generarCitaDAO;

        public GenerarCitaBO()
        {
            generarCitaDAO = new GenerarCitaDAO();
        }
        public object InsertCita(string NombrePaciente, string ApellidoPaterno, string ApellidoMaterno, string Telefono, string Correo, DateTime FechaCita, int idDoctor)
        {
            try
            {
                RegistroCitas citas = this.generarCitaDAO.InsertaCita(NombrePaciente, ApellidoPaterno, ApellidoMaterno, Telefono, Correo, FechaCita, idDoctor);
                return citas;
            }
            catch (Exception x)
            {
                throw x;
            }
        }
    }
}