using MebelShop.Model;
using MebelShop.Model.Requests;
using MebelShop.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MebelShop.Controllers
{
    [Route("mebel-shop")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        #region Services

        private readonly ICatalogRepository _catalogRepository;

        #endregion

        #region Ctor

        public CatalogController(ICatalogRepository catalogRepository)
        {
            _catalogRepository = catalogRepository;
        }

        #endregion

        [HttpPost("catalog/create")]
        public IActionResult Create([FromQuery] CreateCatalogRequest request)
        {
            return Ok(_catalogRepository.Create(new Catalog 
            {
                Id = request.Id,
                CatalogName = request.CatalogName
            }));
        }

        [HttpDelete("catalog/delete")]
        public IActionResult Delete([FromQuery] int id)
        {
            _catalogRepository.Delete(id);
            return Ok();
        }

        [HttpGet("catalog/getall")]
        public IActionResult GetAll()
        {
            return Ok(_catalogRepository.GetAll());
        }

        [HttpGet("catalog/get-id")]
        public IActionResult GetById([FromQuery] int id)
        {
            return Ok(_catalogRepository.GetById(id));
        }

        [HttpPut("catalog/update")]
        public IActionResult Update([FromQuery] Catalog item)
        {
            _catalogRepository.Update(item);
            return Ok();
        }
    }
}
