using ERPQuala.BAL.StockBAL;
using ERPQuala.Crosscutting.Model;
using ERPQuala.DAL.Stock.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERPQuala.BAL.StockBL
{
    public class StockBl : IStockBl
    {
        private readonly IStockDal _stockDal;
        public StockBl(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }
        public Task<IEnumerable<Product>> UpdateAsync(Product parameters)
        {
            return _stockDal.UpdateAsync(parameters);
        }
    }
}
