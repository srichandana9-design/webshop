using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]

        public IEnumerable<string> Get()
        {
            return new string[] { "car", "bus", "Aeroplane", "bike" };
        }

        [HttpGet("{id}")]

        public string Get(int id)
        {
            return "The value is" + id;
        }
    }
}
