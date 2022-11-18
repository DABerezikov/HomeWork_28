using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace HomeWork_28.Data
{
    public class DBConnector
    {
        
        private static readonly NpgsqlConnection Connection = new(SqlLogin.GetConnectionString("Clients_HW_28"));
        private static string sql = "select * from Client_id";
        public NpgsqlCommand Command = new NpgsqlCommand(sql, Connection);
    }
}
       

