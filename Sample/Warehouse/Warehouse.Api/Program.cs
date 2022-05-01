using Core.WebApi.Middlewares.ExceptionHandling;
using Warehouse;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddRouting()
    .AddWarehouseServices();

var app = builder.Build();

app.UseExceptionHandlingMiddleware()
    .UseRouting()
    .UseEndpoints(endpoints =>
    {
        endpoints.UseWarehouseEndpoints();
    })
    .ConfigureWarehouse();

app.Run();

public partial class Program
{
}
