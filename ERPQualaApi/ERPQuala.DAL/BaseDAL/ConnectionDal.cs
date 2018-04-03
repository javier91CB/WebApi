using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ERPQuala.DAL.BaseDAL
{
    public class ConnectionDal
    {
        public NpgsqlTransaction transaction = null;
        public NpgsqlCommand command = null;

        public NpgsqlConnection ConnectionPostgrest()
        {
            try
            {
                string connstring = String.Format("Server=35.184.64.208;Port=5432;" +
                    "User Id=postgres;Password=admin;Database=postgres;");
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                return conn;
            }
            catch (Exception msg)
            {
                throw;
            }
        }
    }
}
