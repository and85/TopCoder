using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChooserApp;

namespace ChooserTests
{
    [TestClass]
    public class ChooserTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int[] easy = new[] { 5, 10, 15 };
            int[] middle = new[] { 15, 25 };
            int[] hard = new[] { 45 };

            int expected = 4;

            RunTest(easy, middle, hard, expected);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int[] easy = new[] { 5, 5, 5 };
            int[] middle = new[] { 15, 15, 15 };
            int[] hard = new[] { 45, 45, 45 };

            int expected = 27;

            RunTest(easy, middle, hard, expected);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            int[] easy = new[] { 5, 5, 5 };
            int[] middle = new[] { 15, 15, 15 };
            int[] hard = new[] { 45, 45, 35 };

            int expected = 18;

            RunTest(easy, middle, hard, expected);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            int[] easy = new int[] { };
            int[] middle = new[] { 15, 25 };
            int[] hard = new[] { 30, 35, 40 };

            int expected = 0;

            RunTest(easy, middle, hard, expected);
        }

        private static void RunTest(int[] easy, int[] middle, int[] hard, int expected)
        {
            // Act
            var chooser = new Chooser();
            int actual = chooser.numSets(easy, middle, hard);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
