using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace app_net_framework.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int a = 5;
            int b = 3;
            int expected = 8;

            // Act
            int result = a + b;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            string input = "Hello World";
            string expected = "HELLO WORLD";

            // Act
            string result = input.ToUpper();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3_ShouldReturnTrue()
        {
            // Arrange
            bool condition = true;

            // Act & Assert
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void TestMethod4_ShouldNotBeNull()
        {
            // Arrange
            object obj = new object();

            // Act & Assert
            Assert.IsNotNull(obj);
        }
    }
}
