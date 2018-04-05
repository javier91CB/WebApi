using ERPQuala.Crosscutting.Model;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ERPQuala.BAL.StockBAL
{
    public interface IStockBl
    {
        Task<IEnumerable<Product>> UpdateAsync(Product product);
        Task<IEnumerable<Product>> GetAsync(Product product);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> DeleteAsync(Product product);
        Task<IEnumerable<Product>> AddAsync(Product product);
    }
}
