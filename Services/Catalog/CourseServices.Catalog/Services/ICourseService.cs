using Course.Shared.DTOs;
using CourseServices.Catalog.DTOs;
using CourseServices.Catalog.Models;

namespace CourseServices.Catalog.Services
{
    public interface ICourseService
    {
        Task<Response<List<CourseDTO>>> GetAllAsync();
        Task<Response<CourseDTO>> GetByIdAsync(string id);
        Task<Response<List<CourseDTO>>> GetAllByUserIdAsync(string userId);
        Task<Response<CourseDTO>> CreateAsync(CourseCreateDTO course);
        Task<Response<NoContent>> UpdateAsync(CourseUpdateDTO course);
        Task<Response<NoContent>> DeleteAsync(string id);
    }
}
