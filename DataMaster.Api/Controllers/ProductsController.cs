using DataMaster.Aplications.ApplicationServices.ProductServices;
using DataMaster.Aplications.ApplicationServices.ProductServices.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataMaster.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _serviceProduct;
        public ProductsController(IProductService serviceProduct)
        {
            _serviceProduct = serviceProduct;
        }
        [HttpPost("Insert")]
        public IActionResult Insert(CreateProductDto model)
        {
            _serviceProduct.Create(model);
            return Ok(model);
        }
        [HttpPost("GetAll")]
        public IActionResult GetALl()
        {
            var products = _serviceProduct.GetAllProduct();
            return Ok(products);
        }


    }
}
