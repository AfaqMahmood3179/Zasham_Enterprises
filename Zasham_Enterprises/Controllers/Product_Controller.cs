using Microsoft.AspNetCore.Mvc;
using Zasham_Enterprises.Model;

namespace Zasham_Enterprises.Controllers
{
    public class Product_Controller : Controller
    {
       
        private readonly CustomerDB_Context _proddbcontext;

        public Product_Controller(CustomerDB_Context customerdbcontext)
        {
            _proddbcontext = customerdbcontext;
        }

        [HttpPut("AddProducts")]
        public IActionResult SaveProducts([FromBody]Product product)
        {
            _proddbcontext.products.Add(product);
            _proddbcontext.SaveChanges();

            return Ok();
        }


        [HttpGet("AllProducts")]
        public IEnumerable<Product> GetProducts()
        {

            return _proddbcontext.products;
        }
    }
}
