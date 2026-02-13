using FinApp.Infra.Data.Extensions;
using FinApp.Domain.Extensions;
using Scalar.AspNetCore;
using FinApp.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//Swager
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Método de extesão
builder.Services.AddEntityFramework(builder.Configuration);
builder.Services.AddDomainService();
var app = builder.Build();

//Middlewares 
app.UseMiddleware<ExceptionMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

//Swagger
app.UseSwagger();
app.UseSwaggerUI();
//Scalar
app.MapScalarApiReference(s => s.WithTheme(ScalarTheme.BluePlanet));

app.UseAuthorization();

app.MapControllers();

app.Run();
