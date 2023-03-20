using Microsoft.AspNetCore.Mvc;
using NUnit;
using UnitTest_API.Models;
using UnitTest_API.IService;
using ILogger = UnitTest_API.IService.ILogger;

namespace UnitTest_API.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly ILogger Logger;
        private readonly IProductService ProductService;
        public ProductsController(ILogger inLogger, IProductService inProductService)
        {
            Logger = inLogger;
            ProductService= inProductService;
        }
        [HttpPost]
        public string Post(Product product)
        {
            Logger.Log("Hight", $"Adding a products with an id {product.ProductName}");
            var productGuid = ProductService.SaveProduct(product);

            return productGuid;
        }
    }
}
