using EA.Dtos.Requests;
using EA.Dtos.Responses;
using EA.Entities;
using EA.Services;
using EA.WebAPI.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await productService.GetProducts();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            ProductListDisplayResponse product = await productService.GetProductById(id);
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddProductRequest request)
        {
            if (ModelState.IsValid)
            {
                int productId = await productService.AddProduct(request);
                return CreatedAtAction(nameof(GetById), new { id = productId }, null);
            }

            return BadRequest(ModelState);

        }
        [HttpPut("{id}")]
        // TODO 1: IsExist Attribute'ü yazılacak:
        [IsExist]
        public async Task<IActionResult> Update(int id, UpdateProductRequest request)
        {
            var existing = await productService.IsProductExists(id);

            if (existing)
            {
                if (ModelState.IsValid)
                {
                    await productService.UpdateProduct(request);
                    return Ok();
                }
                return BadRequest(ModelState);
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        [IsExist]
        public async Task<IActionResult> Delete(int id)
        {
            return await Task.FromResult(Ok());


        }



    }
}
