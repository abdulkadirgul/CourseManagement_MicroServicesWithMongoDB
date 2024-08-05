using AutoMapper;
using CourseServices.Catalog.DTOs;
using CourseServices.Catalog.Models;

namespace CourseServices.Catalog.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Course, CourseDTO>().ReverseMap();
            CreateMap<Feature, FeatureDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();

            CreateMap<Course, CourseCreateDTO>().ReverseMap();
            CreateMap<Course, CourseUpdateDTO>().ReverseMap();
        }
    }
}
