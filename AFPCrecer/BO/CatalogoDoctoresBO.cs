using AFPCrecer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFPCrecer.BO
{
    public class CatalogoDoctoresBO
    {
        private CatalogoDoctoresDAO catalogoDoctoresDAO;

        public CatalogoDoctoresBO()
        {
            catalogoDoctoresDAO = new CatalogoDoctoresDAO();
        }
        public object GetCatalogoDoctores()
        {
            try
            {               
                List<CatalogoDoctores> doctores = this.catalogoDoctoresDAO.GetDoctores();
                return doctores;
            }
            catch (Exception x)
            {
                throw x;
            }
        }
    }
}