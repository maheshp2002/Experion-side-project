using CartSharp.WebApp.Dto;
using CartSharp.WebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CartSharp.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoryService _service;

        public CategoriesController(CategoryService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<CategoryViewDto> Create(CategoryCreateDto dto)
        {
            var result = _service.Create(dto);
            return Ok(result);
        }
    }
}
