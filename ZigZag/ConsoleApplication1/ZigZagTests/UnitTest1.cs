using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace ZigZagTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestExample0()
        {
            int[] seq = new int[] {1, 7, 4, 9, 2, 5};
            RunTest(seq, 6);
        }

        [TestMethod]
        public void TestExample1()
        {
            int[] seq = new int[] { 1, 17, 5, 10, 13, 15, 10, 5, 16, 8 };
            RunTest(seq, 7);
        }

        [TestMethod]
        public void TestExample2()
        {
            int[] seq = new int[] { 44 };
            RunTest(seq, 1);
        }

        [TestMethod]
        public void TestExample3()
        {
            int[] seq = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            RunTest(seq, 2);
        }

        [TestMethod]
        public void TestExample4()
        {
            int[] seq = new int[] { 70, 55, 13, 2, 99, 2, 80, 80, 80, 80, 100, 19, 7, 5, 5, 5, 1000, 32, 32 };
            RunTest(seq, 8);
        }

        [TestMethod]
        public void TestExample5()
        {
            int[] seq = new int[] { 
                                    374, 40, 854, 203, 203, 156, 362, 279, 812, 955, 
                                    600, 947, 978, 46, 100, 953, 670, 862, 568, 188, 
                                    67, 669, 810, 704, 52, 861, 49, 640, 370, 908, 
                                    477, 245, 413, 109, 659, 401, 483, 308, 609, 120, 
                                    249, 22, 176, 279, 23, 22, 617, 462, 459, 244 
                                   };
            RunTest(seq, 36);
        }

        private static void RunTest(int[] input, int expected)
        {
            // Assert
            var zigZag = new ZigZag();

            // Act
            int actual = zigZag.longestZigZag(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
