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
    public class GenerarCitaDAO
    {
        private IDBConnection DB;

        public GenerarCitaDAO()
        {
            DB = new BD();
        }

        public RegistroCitas InsertaCita(string NombrePaciente, string ApellidoPaterno, string ApellidoMaterno, string Telefono, string correo, DateTime FechaCita, int idDoctor)
        {
            SqlConnection dbConn;
            try
            {
                dbConn = DB.GetConnection();
                var queryParameters = new DynamicParameters();

                queryParameters.Add("@NombrePaciente", NombrePaciente);
                queryParameters.Add("@ApellidoPaterno", ApellidoPaterno);
                queryParameters.Add("@ApellidoMaterno", ApellidoMaterno);
                queryParameters.Add("@Telefono", Telefono);
                queryParameters.Add("@Correo", correo);
                queryParameters.Add("@FechaCita", FechaCita);
                queryParameters.Add("@idDoctor", idDoctor);

                var doctores = dbConn.Query<RegistroCitas>("sp_InserCita", queryParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();

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