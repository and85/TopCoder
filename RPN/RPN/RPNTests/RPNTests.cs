using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPN;

namespace RPNTests
{
    [TestClass]
    public class RPNTests
    {
        [TestMethod]
        public void TestExample0()
        {
            // Arrange
            string input = @"2 3 + 6 ~ 7 * -";
            var rpn = new RPN.RPN();
            
            // Act
            int actual = rpn.evaluate(input);
            
            // Assert
            Assert.AreEqual(47, actual);
        }

        [TestMethod]
        public void TestExample1()
        {
            // Arrange
            string input = @"5 ~ ~ ~";
            var rpn = new RPN.RPN();

            // Act
            int actual = rpn.evaluate(input);

            // Assert
            Assert.AreEqual(-5, actual);
        }

        [TestMethod]
        public void TestExample2()
        {
            // Arrange
            string input = @"9 8 7 * * 4 5 - -";
            var rpn = new RPN.RPN();

            // Act
            int actual = rpn.evaluate(input);

            // Assert
            Assert.AreEqual(505, actual);
        }

        [TestMethod]
        public void TestExample3()
        {
            // Arrange
            string input = @"1 + 2 + 3";
            var rpn = new RPN.RPN();

            // Act
            int actual = rpn.evaluate(input);

            // Assert
            Assert.AreEqual(-999, actual);
        }

        [TestMethod]
        public void TestExample4()
        {
            // Arrange
            string input = @"1 9 ~ 2 8 * +";
            var rpn = new RPN.RPN();

            // Act
            int actual = rpn.evaluate(input);

            // Assert
            Assert.AreEqual(-999, actual);
        }
    }
}
