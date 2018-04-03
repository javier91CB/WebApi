using ERPQuala.Crosscutting.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERPQuala.DAL.Stock.Repository
{
    public interface IStockDal
    {
        Task<IEnumerable<Product>> UpdateAsync(Product product);
    }
}
