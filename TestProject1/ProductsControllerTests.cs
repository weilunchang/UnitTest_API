using NSubstitute;
using UnitTest_API.Controllers;
using UnitTest_API.IService;
using UnitTest_API.Models;

namespace TestProject1
{
    [TestFixture]
    public class ProductsControllerTests
    {
        private ILogger Logger;
        private IProductService ProductService;

        private ProductsController ProductsController;

        [SetUp]
        public void SetUp()
        {
            Logger = Substitute.For<ILogger>();
            ProductService = Substitute.For<IProductService>();

            ProductsController = new ProductsController(Logger, ProductService);
        }
        [Test]
        public void DemoGuidTest()
        {
            //Arrange
            var guid = "af95003e-b31c-4904-bfe8-c315c1d2b805";
            var product = new Product { ProductId = "1", ProductName = "Oven", QuantityAvailable = 3 };

            Logger.Log(default, default);
            ProductService.SaveProduct(product).Returns(guid);

            //Act
            var result = ProductsController.Post(product);

            //Assert
            Assert.AreEqual(result, guid);
        }
        [Test]
        public void DemoSaveProductReceiveTest()
        {
            // Arrange
            var guid = "af95003e-b31c-4904-bfe8-c315c1d2b805";
            var product = new Product { ProductId = "1", ProductName = "Oven", QuantityAvailable = 3 };

            Logger.Log(default, default);
            ProductService.SaveProduct(product).Returns(guid);

            // Act
            var result = ProductsController.Post(product);

            // Assert
            ProductService.Received(1).SaveProduct(product);
        }

        [Test]
        public void DemoLogReceiveTest()
        {
            // Arrange
            var guid = "af95003e-b31c-4904-bfe8-c315c1d2b805";
            var product = new Product { ProductId = "1", ProductName = "Oven", QuantityAvailable = 3 };

            Logger.Log(default, default);
            ProductService.SaveProduct(product).Returns(guid);

            // Act
            var result = ProductsController.Post(product);

            // Assert
            Logger.Received(1).Log(default, default);
        }
    }
}