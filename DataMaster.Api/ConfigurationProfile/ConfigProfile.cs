using AutoMapper;
using DataMaster.Aplications.ApplicationServices.ProductServices.Dto;
using DataMaster.Database.ModelDatabases;

namespace DataMaster.Api.ConfigurationProfile
{
    public class ConfigProfile:Profile
    {
        public ConfigProfile() {
            //Product Model
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<CreateProductDto, Product>();


        }
    }
}
