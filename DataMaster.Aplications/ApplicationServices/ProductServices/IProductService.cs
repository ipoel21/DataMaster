using DataMaster.Aplications.ApplicationServices.ProductServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMaster.Aplications.ApplicationServices.ProductServices
{
    public interface IProductService
    {
        void Create(CreateProductDto create);
        void Update(ProductDto update);
        List<ProductDto> GetAllProduct();
        List<ProductDto> SearchByName(string name);
        ProductDto GetById(int Id);
        void Delete(int Id);
    }
}
