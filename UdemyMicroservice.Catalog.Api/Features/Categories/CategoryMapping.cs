using AutoMapper;
using UdemyMicroservice.Catalog.Api.Features.Categories.Dtos;

namespace UdemyMicroservice.Catalog.Api.Features.Categories;

public class CategoryMapping : Profile
{
    public CategoryMapping()
    {
        CreateMap<Category, CategoryDto>();
    }
}