using Course.Shared.DTOs;
using CourseServices.Catalog.DTOs;
using CourseServices.Catalog.Models;

namespace CourseServices.Catalog.Services
{
    public interface ICategoryServices
    {
        Task<Response<List<CategoryDTO>>> GetAllAsync();
        Task<Response<CategoryDTO>> CreateAsync(Category category);
        Task<Response<CategoryDTO>> GetByIdAsync(string id);
    }
}
