using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Products> product = DbProducts.GetProducts();
            return Ok(product);
        }

        // GETapi/<ProductController>
        [HttpGet("{id}")]
        public IActionResult Get(int id)

        {
            List<Products> product = DbProducts.GetProducts();
            return Ok(product[id]);
        }

        // api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // api/<ProductController>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

