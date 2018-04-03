using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPQuala.Crosscutting.Model;
using ERPQuala.BAL.StockBAL;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using System.Net.Http.Headers;

namespace ERPQualaApi.Controllers
{
    [Route("api/[controller]")]
    public class StockController : Controller
    {

        private readonly IStockBl _stockBl;
        public StockController(IStockBl stockBl)
        {
            _stockBl = stockBl;
        }

        [HttpPost]
        public IActionResult UpdateStockAsync([FromBody] Product product)
        {
            return Ok(_stockBl.UpdateAsync(product));
        }

    }
}