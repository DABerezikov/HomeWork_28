using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace HomeWork_28.Data
{
    public class DBConnector
    {
        private readonly NpgsqlConnection _connection;
        NpgsqlDataAdapter _adapter;
        DataTable _data;
        DataRowView _rowView;
        public NpgsqlCommand Command;
        private string _sql;

        public DBConnector()
        {
            _connection = new(SqlLogin.GetConnectionString("Clients_HW_28")); ;
            _adapter = new NpgsqlDataAdapter();
            _data = new DataTable();
           
        }

        public void Preparing()
        {
            #region select

             _sql = "select * from Client Order By Client.ID";
            _adapter.SelectCommand = new NpgsqlCommand(_sql, _connection);

            #endregion

            #region insert

            _sql = @"INSERT INTO Client (Client.ID,";


            #endregion
        }


    }
}
       

