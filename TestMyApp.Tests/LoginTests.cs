using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMyApp.WebApp; // Allows access to LoginHelper

namespace TestMyApp.Tests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void ShouldFailLogin_WhenInvalidCredentials()
        {
            var login = new LoginHelper();
            var result = login.ValidateLogin("fake@test.com", "wrongpass");

            Assert.IsFalse(result); // Expecting login to fail
        }

        [TestMethod]
        public void ShouldPassLogin_WhenCorrectCredentials()
        {
            var login = new LoginHelper();
            var result = login.ValidateLogin("admin@test.com", "Pass123");

            Assert.IsTrue(result); // Expecting login to succeed
        }
    }
}
