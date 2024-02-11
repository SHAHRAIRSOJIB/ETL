using ExelTechApi.Service.BussinessLayer.Interface;
using ExelTechApi.Service.BussinessLayer.Repository;
using ExelTechApi.Service.Model;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ExelTechDbContext>(option=> option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"),x=>x.MigrationsAssembly("ExelTechApi.Service")));
builder.Services.AddScoped<IPatient, PatientRepository>();
builder.Services.AddScoped<IDropDown, DropDownRepositopry>();
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
