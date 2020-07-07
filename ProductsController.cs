using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Services;
using ContosoCraftsWebsite.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoCraftsWebsite.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        
        // GET: /<controller>/
        public ProductsController(JsonFileProductService productService)
        {
            this.ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }
        
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }
        // [HttpPatch] [FromBody]"
        [Route("Rate")]
        [HttpGet]

        public ActionResult Get(
           [FromQuery] string ProductId, 
           [FromQuery] int Rating)
        {
            ProductService.AddRating(ProductId, Rating);
            return Ok();
        }
    }
}
