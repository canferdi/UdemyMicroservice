using UdemyMicroservice.Catalog.Api.Features.Courses.Create;
using UdemyMicroservice.Catalog.Api.Features.Courses.GetAll;
using UdemyMicroservice.Catalog.Api.Features.Courses.GetById;

namespace UdemyMicroservice.Catalog.Api.Features.Courses;

public static class CourseEndpointExt
{
    public static void AddCourseGroupEndpointExt(this WebApplication app)
    {
        app.MapGroup("api/courses")
            .WithTags("Courses")
            .CreateCourseGroupItemEndpoint()
            .GetAllCoursesGroupItemEndpoint()
            .GetCourseByIdGroupItemEndpoint();
    }
}