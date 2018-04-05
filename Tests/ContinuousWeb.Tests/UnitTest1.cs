using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContinuousWeb.Controllers;

namespace ContinuousWeb.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AboutPageTest()
        {
            var homeController = new HomeController();
            var result = homeController.About();
        }

    }
}
