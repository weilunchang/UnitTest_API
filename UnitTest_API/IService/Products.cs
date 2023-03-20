using UnitTest_API.Models;

namespace UnitTest_API.IService
{
    // 登記 Log 的服務
    public interface ILogger
    {
        public void Log(string level, string message);
    }

    // 產品 Product 的服務
    public interface IProductService
    {
        public string SaveProduct(Product product);
    }
}