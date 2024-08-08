using Course.SharedNew.ControllerBases;
using CourseServices.Catalog.DTOs;
using CourseServices.Catalog.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseServices.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : CustomBaseController
    {
        public readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            this._courseService = courseService;
        }

        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _courseService.GetAllAsync();

            return CreateActionResultInstance(response);
        }

        [HttpGet]
        [Route("/api/[controller]/GetById/{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var response = await _courseService.GetByIdAsync(id);

          return CreateActionResultInstance(response);
        }


        [HttpGet]
        [Route("/api/[controller]/GetAllByUserId/{userId}")]
        public async Task<IActionResult> GetAllByUserId(string userId)
        {
            var response = await _courseService.GetByIdAsync(userId);

            return CreateActionResultInstance(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseCreateDTO courseCreateDTO)
        {
            var response = await _courseService.CreateAsync(courseCreateDTO);

            return CreateActionResultInstance(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(CourseUpdateDTO courseUpdateDTO)
        {
            var response = await _courseService.UpdateAsync(courseUpdateDTO);

            return CreateActionResultInstance(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            var response = await _courseService.DeleteAsync(id);

            return CreateActionResultInstance(response);
        }
    }
}
