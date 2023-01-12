using DataMaster.Database.DataMasterContext;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using DataMaster.Api.ConfigurationProfile;
using DataMaster.Aplications.ApplicationServices.ProductServices;

var builder = WebApplication.CreateBuilder(args);

//AutoMapper
var config = new AutoMapper.MapperConfiguration(cfg =>
{
    cfg.AddProfile(new ConfigProfile());
});
IMapper mapper = config.CreateMapper();

// Add services to the container.

builder.Services.AddDbContext<DMContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
});

builder.Services.AddSingleton(mapper);
builder.Services.AddTransient<IProductService, ProductService>();

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
