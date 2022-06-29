using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Navtech_Assignment.Data;
using Navtech_Assignment.Models;

namespace Navtech_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {

        private readonly ProductDbContext _product1;

        public DefaultController (ProductDbContext product1)
        {
            _product1 = product1;
        }

        [HttpPost]
        public async Task<IActionResult> GetProducts(Product product)
        {
            await _product1.Product.AddAsync(product);
            await _product1.SaveChangesAsync();

            return Ok(StatusCode(200));
        }


    }
}
