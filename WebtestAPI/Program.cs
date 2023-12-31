using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using WebtestAPI.Context;
using WebtestAPI.Controllers;
using WebtestAPI.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TestApiContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("strConnect")));

builder.Services.AddScoped<IServiceProduct, ServiceProduct>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
