using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMyApp.WebApp.Pages;

namespace TestMyApp.Tests
{
    [TestClass]
    public class PrimeCheckerTests
    {
        [TestMethod]
        public void ShouldReturnFalse_WhenNumberIsOne()
        {
            var page = new CheckPrimeModel();
            page.Number = 1;
            page.OnPost();
            Assert.AreEqual("1 is not a prime number.", page.ResultMessage);
        }

        [TestMethod]
        public void ShouldReturnTrue_WhenNumberIsTwo()
        {
            var page = new CheckPrimeModel();
            page.Number = 2;
            page.OnPost();
            Assert.AreEqual("2 is a prime number.", page.ResultMessage);
        }

        [TestMethod]
        public void ShouldReturnFalse_WhenNumberIsTen()
        {
            var page = new CheckPrimeModel();
            page.Number = 10;
            page.OnPost();
            Assert.AreEqual("10 is not a prime number.", page.ResultMessage);
        }
    }
}
