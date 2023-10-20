using Domain.ICamiones;
using Domain.IConnection;
using Infraestructure;
using Infraestructure.Connection;
using Microsoft.Extensions.Configuration;
using System.Web.Helpers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Add services to the container.
//conexion
builder.Services.AddScoped<IConnection, ConnectionBD>();
builder.Services.AddScoped<ICamiones, servicioCamion>();

var app = builder.Build();
app.UseCors(options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
