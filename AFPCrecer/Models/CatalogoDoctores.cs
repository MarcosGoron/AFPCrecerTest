using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFPCrecer.Models
{
    public class CatalogoDoctores
    {
        public int idDoctor { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int idAreaEsp { get; set; }
    }
}