using AFPCrecer.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AFPCrecer.Models
{
    public class CatalogoDoctoresDAO
    {
        private IDBConnection DB;

        public CatalogoDoctoresDAO()
        {
            DB = new BD();
        }

        public List<CatalogoDoctores> GetDoctores()
        {
            SqlConnection dbConn;
            try
            {
                dbConn = DB.GetConnection();
                var doctores = dbConn.Query<CatalogoDoctores>("sp_GetDoctores", commandType: CommandType.StoredProcedure).ToList();

                return doctores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DB.CloseConnection();
            }
        }
    }    
}