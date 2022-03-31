using AFPCrecer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFPCrecer.BO
{
    public class CatalogoAreasEspBO
    {
        private CatalogoAreasEspDAO catalogoAreasEspDAO;

        public CatalogoAreasEspBO()
        {
            catalogoAreasEspDAO = new CatalogoAreasEspDAO();
        }
        public object GetCatalogoAreas()
        {
            try
            {
                List<CatalogoAreasEsp> areas = this.catalogoAreasEspDAO.GetAreas();
                return areas;
            }
            catch (Exception x)
            {
                throw x;
            }
        }
    }
}