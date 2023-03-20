using UnitTest_API.IService;
using UnitTest_API.Models;
using ILogger = UnitTest_API.IService.ILogger;

namespace UnitTest_API.Service
{
    public class Logger : ILogger
    {
        public void Log(string level, string message)
        {
            // 撰寫你要的功能，並非測試重點，所以不詳細列述
        }
        // 產品 Product 的服務
        public class ProductService : IProductService
        {
            public string SaveProduct(Product product)
            {
                // 撰寫你要的功能，並非測試重點，所以不詳細列述
                return "";
            }
        }
    }
}
