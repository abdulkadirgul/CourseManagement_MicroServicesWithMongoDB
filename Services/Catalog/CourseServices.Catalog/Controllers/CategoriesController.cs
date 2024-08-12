using Course.SharedNew.ControllerBases;
using CourseServices.Catalog.DTOs;
using CourseServices.Catalog.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseServices.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryServices _categoryServices;

        public CategoriesController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryServices.GetAllAsync();
        
            return CreateActionResultInstance(categories);
        }

        [HttpGet]
        [Route("/api/[controller]/GetAllById/{id}")]
        public async Task<IActionResult> GetAllById(string id)
        {
            var categories = await _categoryServices.GetByIdAsync(id);

            return CreateActionResultInstance(categories);
        }

        [HttpPost]
        [Route("/api/[controller]/GetAllById/{id}")]
        public async Task<IActionResult> CreateAsync(CategoryDTO categoryDTO)
        {
            var response = await _categoryServices.CreateAsync(categoryDTO);

            return CreateActionResultInstance(response);
        }

    }
}
