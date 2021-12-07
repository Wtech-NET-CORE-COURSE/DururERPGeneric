using Durur.Modules.Business.Abstract;
using Durur.Modules.Business.Concrete;
using Durur.Modules.Entities;
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
        private IProductServices _productServices;

        public ProductController()
        {
            _productServices = new ProductServices();
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
            var product = _productServices.GetProductByID(id);
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _productServices.AddProduct(product);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            _productServices.UpdateProduct(product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            if (_productServices.GetProductByID(id) != null)
            {
                _productServices.DeleteProduct(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
