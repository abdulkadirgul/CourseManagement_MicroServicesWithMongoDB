using AutoMapper;
using CourseServices.Catalog.DTOs;
using CourseServices.Catalog.Models;

namespace CourseServices.Catalog.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Models.Course, CourseDTO>().ReverseMap();
            CreateMap<Feature, FeatureDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();

            CreateMap<Models.Course, CourseCreateDTO>().ReverseMap();
            CreateMap<Models.Course, CourseUpdateDTO>().ReverseMap();
        }
    }
}
