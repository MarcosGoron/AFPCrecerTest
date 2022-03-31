using AFPCrecer.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AFPCrecer.Controllers
{
    public class CargaInicialController : Controller
    {
        private CatalogoDoctoresBO catalogoDoctoresBO;
        private CatalogoAreasEspBO catalogoAreasEspBO;
        private GenerarCitaBO generarCitaBO;

        public CargaInicialController()
        {
            this.catalogoDoctoresBO = new CatalogoDoctoresBO();
            this.catalogoAreasEspBO = new CatalogoAreasEspBO();
            this.generarCitaBO = new GenerarCitaBO();
        }

        // GET: CargaInicial
        public ActionResult Index()
        {
            try
            {
                ViewBag.listaDoctores = this.catalogoDoctoresBO.GetCatalogoDoctores();
                ViewBag.listaAreas = this.catalogoAreasEspBO.GetCatalogoAreas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(ViewBag.listaDoctores, ViewBag.listaAreas);
        }
        [HttpPost]
        public ActionResult InsertarCita(string NombrePaciente, string ApellidoPaterno, string ApellidoMaterno, string Telefono, string Correo, DateTime FechaCita, int idDoctor)
        {
            try
            {
                var citas = this.generarCitaBO.InsertCita(NombrePaciente, ApellidoPaterno, ApellidoMaterno, Telefono, Correo, FechaCita, idDoctor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View();
        }
    }
}