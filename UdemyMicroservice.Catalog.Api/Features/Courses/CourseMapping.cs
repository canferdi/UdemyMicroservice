using UdemyMicroservice.Catalog.Api.Features.Courses.Create;

namespace UdemyMicroservice.Catalog.Api.Features.Courses;

public class CourseMapping : Profile
{
    public CourseMapping()
    {
        CreateMap<CreateCourseCommand, Course>();
    }
}