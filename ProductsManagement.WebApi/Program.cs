using Microsoft.EntityFrameworkCore;
using ProductsManagement.DataAccess;
using ProductsManagement.DataAccess.Repositories;
using ProductsManagement.Service;
using ProductsManagement.WebApi;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddTransient<IProductRepo, ProductRepo>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddControllers();


// Add services to the container.




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProductDBContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ValidateModelFilter>();

var app = builder.Build();

app.UseMiddleware<LoggingMiddleware>();


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
