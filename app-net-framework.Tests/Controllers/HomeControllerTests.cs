using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using app_net_framework.Controllers;

namespace app_net_framework.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void HomeController_CanBeInstantiated()
        {
            // Arrange & Act
            var controller = new HomeController();

            // Assert
            Assert.IsNotNull(controller);
            Assert.IsInstanceOfType(controller, typeof(HomeController));
        }

        [TestMethod]
        public void HomeController_InheritsFromController()
        {
            // Arrange & Act
            var controller = new HomeController();

            // Assert
            Assert.IsInstanceOfType(controller, typeof(Controller));
        }

        [TestMethod]
        public void HomeController_HasAuthorizeAttribute()
        {
            // Arrange
            var controllerType = typeof(HomeController);

            // Act
            var attributes = controllerType.GetCustomAttributes(typeof(AuthorizeAttribute), true);

            // Assert
            Assert.IsTrue(attributes.Length > 0, "El HomeController debe tener el atributo [Authorize]");
        }
    }
}