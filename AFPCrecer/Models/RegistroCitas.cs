using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFPCrecer.Models
{
    public class RegistroCitas
    {
        public int idCita { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime FechaCita { get; set; }
        public int idDoctor { get; set; }

    }
}