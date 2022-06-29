using Microsoft.AspNetCore.Mvc;
using Navtech_Assignment.Data;
using Navtech_Assignment.Models;

namespace Navtech_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisplayController : Controller
    {

        private readonly ProductDbContext _product1;

        public DisplayController(ProductDbContext product1)
        {
            _product1 = product1;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return  _product1.Product.ToList();
        }

    }
}
