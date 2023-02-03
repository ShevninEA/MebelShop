using MebelShop.Model;
using MebelShop.Model.Requests;
using MebelShop.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MebelShop.Controllers
{
    [Route("shop/product")]
    [ApiController]
    public class ProductConroller : ControllerBase
    {
        #region Services

        private readonly IProductRepository _productRepository;

        #endregion

        #region Ctor

        public ProductConroller(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        #endregion

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateProductRequest request) 
        {
            return Ok(_productRepository.Create(new Model.Product 
            {
                Id = request.Id,
                Name = request.Name,    
                ShortDesc = request.ShortDesc,
                LongDesc = request.LongDesc,
                Img = request.Img,
                Price = request.Price,
                IsFavorite = request.IsFavorite,
                CatalogId = request.CatalogId,
                CategoryId = request.CategoryId
            }));
        }
    }
}
