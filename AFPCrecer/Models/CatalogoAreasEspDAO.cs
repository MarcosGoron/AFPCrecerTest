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
    public class CatalogoAreasEspDAO
    {
        private IDBConnection DB;

        public CatalogoAreasEspDAO()
        {
            DB = new BD();
        }

        public List<CatalogoAreasEsp> GetAreas()
        {
            SqlConnection dbConn;
            try
            {
                dbConn = DB.GetConnection();
                var doctores = dbConn.Query<CatalogoAreasEsp>("sp_GetAreasEspecializadas", commandType: CommandType.StoredProcedure).ToList();

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