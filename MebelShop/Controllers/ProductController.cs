using MebelShop.Data;
using MebelShop.Model;
using MebelShop.Model.Requests;
using MebelShop.Services;
using MebelShop.Services.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MebelShop.Controllers
{
    [Route("mebel-shop")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region Services

        private readonly IProductRepository _productRepository;

        #endregion

        #region Ctor

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        #endregion

        [HttpPost("product/create")]
        public IActionResult Create([FromBody] CreateProductRequest request) 
        {
            return Ok(_productRepository.Create(new Product 
            {
                Id = request.Id,
                ProductName = request.ProductName,    
                ShortDesc = request.ShortDesc,
                LongDesc = request.LongDesc,
                Img = request.Img,
                Price = request.Price,
                IsFavorite = request.IsFavorite,
                Available = request.Available,
                CatalogId = request.CatalogId,
                CategoryId = request.CategoryId
            }));
        }

        [HttpDelete("product/delete")]
        public IActionResult Delete([FromQuery] int id)
        {
            _productRepository.Delete(id);
            return Ok();
        }

        [HttpGet("product/getall")]
        public IActionResult GetAll()
        {
            return Ok(_productRepository.GetAll());
        }

        [HttpGet("product/get-id")]
        public IActionResult GetById([FromQuery] int id)
        {
            return Ok(_productRepository.GetById(id));
        }

        [HttpPut("product/update")]
        public IActionResult Update([FromQuery] Product item)
        {
            _productRepository.Update(item);
            return Ok();
        }
    }
}
