using MebelShop.Model.Requests;
using MebelShop.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MebelShop.Controllers
{
    [Route("shop/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        #region Services

        private readonly ICategoryRepository _categoryRepository;

        #endregion

        #region Ctor

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        #endregion

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateCategoryRequest request)
        {
            return Ok(_categoryRepository.Create(new Model.Category 
            {
                Id = request.Id,
                CategoryName = request.CategoryName,
                CatalogId = request.CatalogId
            }));
        }
    }
}
