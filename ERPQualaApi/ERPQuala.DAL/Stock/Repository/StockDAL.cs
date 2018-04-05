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
        public StockDal(WebAPIDataContext webAPIDataContext)
        {
            _webAPIDataContext = webAPIDataContext;
        }

        public Task<IEnumerable<Product>> UpdateAsync(Product product)
        {
            var response = _webAPIDataContext.Products.Update(product);
            _webAPIDataContext.SaveChangesAsync();
            return Task.FromResult(response as IEnumerable<Product>);
        }

        public Task<IEnumerable<Product>> GetAsync(Product product)
        {
            var response = _webAPIDataContext.Products.FindAsync(product.Code);
            return Task.FromResult(response as IEnumerable<Product>);
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            var response = _webAPIDataContext.Products;
            return Task.FromResult(response as IEnumerable<Product>);
        }

        public Task<IEnumerable<Product>> DeleteAsync(Product product)
        {
            var response = _webAPIDataContext.Products.Remove(product);
            _webAPIDataContext.SaveChangesAsync();
            return Task.FromResult(response as IEnumerable<Product>);
        }

        public Task<IEnumerable<Product>> AddAsync(Product product)
        {
            var response = _webAPIDataContext.Products.Update(product);
            _webAPIDataContext.SaveChangesAsync();
            return Task.FromResult(response as IEnumerable<Product>);
        }
    }
}
