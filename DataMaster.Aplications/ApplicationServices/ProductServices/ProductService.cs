using AutoMapper;
using DataMaster.Aplications.ApplicationServices.ProductServices.Dto;
using DataMaster.Database.DataMasterContext;
using DataMaster.Database.ModelDatabases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMaster.Aplications.ApplicationServices.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly DMContext _dMContext;
        private readonly IMapper _mapper;
        public ProductService(DMContext dMContext,IMapper mapper)
        {
            _mapper= mapper;
            _dMContext = dMContext;
        }
        public void Create(CreateProductDto create)
        {
            var product = _mapper.Map<Product>(create);
            _dMContext.Products.Add(product);
            _dMContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            var product = _dMContext.Products.FirstOrDefault(w => w.Id == Id);
            var delProduct = _mapper.Map<Product>(product);
            _dMContext.Products.Remove(product);
            _dMContext.SaveChanges();
        }

        public List<ProductDto> GetAllProduct()
        {
            var products = _dMContext.Products.ToList();
            return _mapper.Map<List<ProductDto>>(products);
        }

        public ProductDto GetById(int Id)
        {
            var products = _dMContext.Products.FirstOrDefault(w => w.Id == Id);
            return _mapper.Map<ProductDto>(products);
        }

        public List<ProductDto> SearchByName(string name)
        {
            var products = _dMContext.Products.Where(w => w.ProductName.Contains(name)).ToList();
            return _mapper.Map<List<ProductDto>>(products);
        }

        public void Update(ProductDto update)
        {
            var product = _mapper.Map<Product>(update);
            _dMContext.Products.Update(product);
            _dMContext.SaveChanges();
        }
    }
}
