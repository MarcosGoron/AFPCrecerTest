using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFPCrecer.Interfaces
{
    interface IDBConnection
    {
        SqlConnection GetConnection();
        void CloseConnection();
        bool Testconnection();
    }
}
