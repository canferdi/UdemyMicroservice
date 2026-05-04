using MediatR;
using Microsoft.EntityFrameworkCore;
using UdemyMicroservice.Catalog.Api.Features.Categories.Dtos;
using UdemyMicroservice.Catalog.Api.Repositories;
using UdemyMicroservice.Shared;
using UdemyMicroservice.Shared.Extensions;

namespace UdemyMicroservice.Catalog.Api.Features.Categories.GetAll;

public class GetAllCategoryQuery : IRequest<ServiceResult<List<CategoryDto>>>;

public class GetAllCategoryHandler(AppDbContext context) : IRequestHandler<GetAllCategoryQuery, ServiceResult<List<CategoryDto>>>
{
    public async Task<ServiceResult<List<CategoryDto>>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
    {
        var categories = await context.Categories.ToListAsync(cancellationToken: cancellationToken);
        var categoriesAsDto = categories.Select(x => new CategoryDto(x.Id, x.Name)).ToList();
        return ServiceResult<List<CategoryDto>>.SuccessAsOk(categoriesAsDto);
    }
}

public static class GetAllCategoryEndpoint
{
    public static RouteGroupBuilder GetAllCategoryGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/",
            async (IMediator mediator) => (await mediator.Send(new GetAllCategoryQuery())).ToGenericResult());

        return group;
    }
}