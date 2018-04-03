using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ERPQuala.Crosscutting.Model;
using Npgsql;

namespace ERPQuala.DAL.Stock.Repository
{
    public class StockDal : IStockDal
    {
        private readonly WebAPIDataContext _webAPIDataContext;
        IServiceProvider _service;
        public StockDal(IServiceProvider service, WebAPIDataContext webAPIDataContext)
        {
            _service = service;
            _webAPIDataContext = webAPIDataContext;
        }

        public static IDbConnection OpenConnection(string connStr)
        {
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public Task<IEnumerable<Product>> UpdateAsync(Product product)
        {
            using (var conn = OpenConnection("Server=http://alfrescoasof.eastus.cloudapp.azure.com; Port=5433; Database=qualaerp; UserId=openpg; Password=openpgpwd;"))
            {
                var querySQL = @"SELECT * FROM product_product";
                NpgsqlCommand command = new NpgsqlCommand(querySQL);
                var list = command.ExecuteNonQuery();
            }

            var response = _webAPIDataContext.Productos;
            return Task.FromResult(response as IEnumerable<Product>);
        }
    }
}
