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

        [HttpPost("category/create")]
        public IActionResult Create([FromQuery] CreateCategoryRequest request)
        {
            return Ok(_categoryRepository.Create(new Category 
            {
                Id = request.Id,
                CategoryName = request.CategoryName,
                CatalogId = request.CatalogId
            }));
        }

        [HttpDelete("category/delete")]
        public IActionResult Delete([FromQuery] int id)
        {
            _categoryRepository.Delete(id);
            return Ok();
        }

        [HttpGet("category/getall")]
        public IActionResult GetAll()
        {
            return Ok(_categoryRepository.GetAll());
        }

        [HttpGet("category/get-id")]
        public IActionResult GetById([FromQuery] int id)
        {
            return Ok(_categoryRepository.GetById(id));
        }

        [HttpPut("category/update")]
        public IActionResult Update([FromQuery] Category item)
        {
            _categoryRepository.Update(item);
            return Ok();
        }
    }
}
