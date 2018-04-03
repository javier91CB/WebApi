using ERPQuala.Crosscutting.Model;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ERPQuala.BAL.StockBAL
{
    public interface IStockBl
    {
        Task<IEnumerable<Product>> UpdateAsync(Product parameters);
    }
}
