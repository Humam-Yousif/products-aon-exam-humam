using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsAonExam.Models;
using ProductsAonExam.Models.DTOs;

namespace ProductsAonExam.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private List<Product> products = new List<Product>();

        [HttpPost]
        public IActionResult CreateProduct(ProductInputDTO product)
        {
            if (product == null)
                return BadRequest("Please insert valid data !");

            Product tempPrudouct = new Product();
            var lastProduct = products.LastOrDefault();
            if (lastProduct == null) {
                _ = new Product(1, product);
            }

            else {
                _ = new Product(lastProduct.Id + 1, product);
            }
            

            products.Add(tempPrudouct);
            return CreatedAtAction("Created", product);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetProduct([FromRoute] int id)
        {
            Product StoredProduct = products.FirstOrDefault(p => p.Id == id);
            if (StoredProduct == null)
                return NotFound("The project is not found !");

            return Ok(StoredProduct);
        }

    }
}
