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

            var lastProduct = products.LastOrDefault();
            Product tempPrudouct = new Product(1, product);
            if (lastProduct == null)
            {
                tempPrudouct.Id = 1;
                products.Add(tempPrudouct);
                return CreatedAtAction("Created", product);
            }

            tempPrudouct.Id = lastProduct.Id + 1;

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
