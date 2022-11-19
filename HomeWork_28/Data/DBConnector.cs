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

        public void Preraring()
        {
            #region select

             _sql = "select * from Client_HW_28 Order By Client_HW_28.Client_id";
            _adapter.SelectCommand = new NpgsqlCommand(_sql, _connection);

            #endregion

            #region insert

            _sql = @"INSERT INTO Clients_HW_28 (Client_id,";


            #endregion
        }


    }
}
       

