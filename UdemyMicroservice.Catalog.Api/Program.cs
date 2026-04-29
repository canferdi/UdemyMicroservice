using Scalar.AspNetCore;
using UdemyMicroservice.Catalog.Api.Options;
using UdemyMicroservice.Catalog.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddApplicationInsightsTelemetry();
builder.Services.AddOptionsExt();
builder.Services.AddDatabaseServiceExt();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.Run();
