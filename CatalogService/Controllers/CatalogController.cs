using CatalogService.Database;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CatalogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly DatabaseContext context;

        public CatalogController(DatabaseContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(context.Products.ToList());
        }
        [HttpPost]
        public IActionResult AddProducts(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return Ok();
        }
    }
}
