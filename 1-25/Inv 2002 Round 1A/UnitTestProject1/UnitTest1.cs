using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplaintsProblem;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod0()
        {
            // Arrange
            int expected = 4;
            int[] line = { 1000, 800, 900, 1400 };
            RunTest(expected, line);
        }

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int expected = 10;
            int[] line = { 1, 2, 3, 4, 5 };
            RunTest(expected, line);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int expected = 0;
            int[] line = { 10, 9, 8, 7, 6, 5 };
            RunTest(expected, line);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            int expected = 16;
            int[] line = { 0, 0, 0, 0, 4000, 4000, 4000, 4000 };
            RunTest(expected, line);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            int expected = 4;
            int[] line = { 1000, 0, 4000, 2000 };
            RunTest(expected, line);
        }

        [TestMethod]
        public void TestMethod5()
        {
            // Arrange
            int expected = 0;
            int[] line = { 0 };
            RunTest(expected, line);
        }

        private static void RunTest(int expected, int[] line)
        {
            // Act
            var complaints = new Complaints();
            int actual = complaints.howMany(line);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
