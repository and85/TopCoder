using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ANDEquation;

namespace ANDEquationTests
{
    [TestClass]
    public class ANDEquationTests
    {
        [TestMethod]
        public void TestCase0()
        {
            var equation = new ANDEquation.ANDEquation();

            var A = new int[] { 1, 3, 5 };
            int actual = equation.restoreY(A);

            Assert.AreEqual(1, actual);
        }
        
        [TestMethod]
        public void TestCase1()
        {
            var equation = new ANDEquation.ANDEquation();

            var A = new int[] { 31, 7 };
            int actual = equation.restoreY(A);

            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void TestCase2()
        {
            var equation = new ANDEquation.ANDEquation();

            var A = new int[] { 31, 7, 7 };
            int actual = equation.restoreY(A);

            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void TestCase3()
        {
            var equation = new ANDEquation.ANDEquation();

            var A = new int[] { 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1 };
            int actual = equation.restoreY(A);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestCase4()
        {
            var equation = new ANDEquation.ANDEquation();

            var A = new int[] { 191411, 256951, 191411, 191411, 191411, 256951, 195507, 191411, 192435, 191411, 191411, 195511, 191419, 191411, 256947, 191415, 191475, 195579, 191415, 191411, 191483, 191411, 191419, 191475, 256947, 191411, 191411, 191411, 191419, 256947, 191411, 191411, 191411 };
            int actual = equation.restoreY(A);

            Assert.AreEqual(191411, actual);
        }

        [TestMethod]
        public void TestCase5()
        {
            var equation = new ANDEquation.ANDEquation();

            var A = new int[] { 1362, 1066, 1659, 2010, 1912, 1720, 1851, 1593, 1799, 1805, 1139, 1493, 1141, 1163, 1211 };
            int actual = equation.restoreY(A);

            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void TestCase6()
        {
            var equation = new ANDEquation.ANDEquation();

            var A = new int[] { 2, 3, 7, 19 };
            int actual = equation.restoreY(A);

            Assert.AreEqual(-1, actual);
        }
    }
}
