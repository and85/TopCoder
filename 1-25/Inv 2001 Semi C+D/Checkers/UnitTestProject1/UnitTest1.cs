using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckersApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Assert
            var expected = 3;
            var startPos = "1,0";
            var input = new[] { "2,1", "0,3", "4,3", "5,6", "4,2" };

            RunTest(expected, startPos, input);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Assert
            var expected = 3;
            var startPos = "4,4";
            var input = new string[] {};

            RunTest(expected, startPos, input);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Assert
            var expected = -1;
            var startPos = "4,4";
            var input = new[] { "6,6", "5,5", "3,5", "2,6" };

            RunTest(expected, startPos, input);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Assert
            var expected = 3;
            var startPos = "4,1";
            var input = new[] { "2,4", "3,4", "4,4", "5,4", "2,6", "3,6", "4,6", "5,6" };

            RunTest(expected, startPos, input);
        }

        private static void RunTest(int expected, string startPos, string[] input)
        {
            // Act
            var checkers = new Checkers();
            int actual = checkers.compute(startPos, input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
