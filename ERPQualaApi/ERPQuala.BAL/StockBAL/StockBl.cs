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
        public Task<IEnumerable<Product>> UpdateAsync(Product product)
        {
            return _stockDal.UpdateAsync(product);
        }
        public Task<IEnumerable<Product>> AddAsync(Product product)
        {
            return _stockDal.AddAsync(product);
        }

        public Task<IEnumerable<Product>> DeleteAsync(Product product)
        {
            return _stockDal.DeleteAsync(product);
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            return _stockDal.GetAllAsync();
        }

        public Task<IEnumerable<Product>> GetAsync(Product product)
        {
            return _stockDal.GetAsync(product);
        }

        
    }
}
