using AFPCrecer.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AFPCrecer.Models
{
    public class BD : IDBConnection
    {
        private string server { get; set; }
        private string bd { get; set; }

        private SqlConnection Connection;
        private string ConnectionString = "";
        private AppSettingsReader appSettings;

        public DB()
        {
            Connection = new SqlConnection();
            appSettings = new AppSettingsReader();
            this.SetDBParameters();
            ConnectionString = "Persist Security Info=False;Trusted_Connection=True; database=" + bd + ";server=" + server;

        }

        private void SetDBParameters()
        {
            server = appSettings.GetValue("DESKTOP-6OHTSQR_DBServer", typeof(string)).ToString();
            bd = appSettings.GetValue("AFPCrecer_DBName", typeof(string)).ToString();
        }

        public SqlConnection GetConnection()
        {
            this.Connection = null;
            try
            {
                this.Connection = new SqlConnection(this.ConnectionString);
                this.Connection.Open();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return this.Connection;
        }

        public void CloseConnection()
        {
            try
            {
                if (this.Connection.State == System.Data.ConnectionState.Open)
                {
                    this.Connection.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Testconnection()
        {
            Boolean Success = false;
            try
            {
                this.Connection = new SqlConnection(this.ConnectionString);
                this.Connection.Open();
                Success = true;
            }
            catch (SqlException)
            {
                Success = false;

            }
            finally
            {
                if (this.Connection.State == System.Data.ConnectionState.Open)
                {
                    this.Connection.Close();
                }
            }
            return Success;
        }
    }
}