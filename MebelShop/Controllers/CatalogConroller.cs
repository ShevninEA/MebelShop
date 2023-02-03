using MebelShop.Model.Requests;
using MebelShop.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MebelShop.Controllers
{
    [Route("shop/catalog")]
    [ApiController]
    public class CatalogConroller : ControllerBase
    {
        #region Services

        private readonly ICatalogRepository _catalogRepository;

        #endregion

        #region Ctor

        public CatalogConroller(ICatalogRepository catalogRepository)
        {
            _catalogRepository = catalogRepository;
        }

        #endregion

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateCatalogRequest request)
        {
            return Ok(_catalogRepository.Create(new Model.Catalog 
            {
                Id = request.Id,
                CatalogName = request.CatalogName
            }));
        }
    }
}
