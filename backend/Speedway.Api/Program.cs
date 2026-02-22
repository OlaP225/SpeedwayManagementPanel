using Microsoft.EntityFrameworkCore;
using Speedway.Api.Data;
// using Scalar.AspNetCore; for now i switch to swagger

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();
//builder.Services.AddOpenApi(); for now i switch to swagger
// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDBContext> (options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
}
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.MapOpenApi(); for now i switch to swagger
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization(); // added while adding swagger
app.MapControllers();
// app.MapScalarApiReference(); For now i switch to swagger

app.Run();

    