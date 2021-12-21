using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Durur.Modules.Api.Controllers
{
    /// <summary>
    /// Product controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var products = await _productServices.GetProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var product = _productServices.GetProductByIDAsync(id);
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _productServices.AddProductAsync(product);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            _productServices.UpdateProduct(product,product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            if (_productServices.GetProductByIDAsync(id) != null)
            {
                _productServices.RemoveProduct(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
