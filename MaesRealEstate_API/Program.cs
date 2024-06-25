using MaesRealEstate_API.Models.DapperContext;
using MaesRealEstate_API.Repositories.BottomGridRepositories;
using MaesRealEstate_API.Repositories.CategoryRepository;
using MaesRealEstate_API.Repositories.ProductRepository;
using MaesRealEstate_API.Repositories.ServiceRepository;
using MaesRealEstate_API.Repositories.WhoWeAreRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<Context>();
builder.Services.AddTransient<IWoWeAreDetailControllerRepository, CategoryRepository>(); 
builder.Services.AddTransient<IProductRepository, ProductRepository>(); 
builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>(); 
builder.Services.AddTransient<IServiceRepository, ServiceRepository>(); 
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>(); 
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
