﻿namespace CourseServices.Catalog.DTOs
{
    public class CourseUpdateDTO
    {
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? UserId { get; set; }
        public string? Picture { get; set; }     
        public FeatureDTO Feature { get; set; }
        public string? CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
    }
}
