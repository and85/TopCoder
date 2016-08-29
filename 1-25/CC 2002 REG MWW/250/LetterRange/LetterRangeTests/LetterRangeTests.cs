using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LetterRangeApp;

namespace LetterRangeTests
{
    [TestClass]
    public class LetterRangeTests
    {
        [TestMethod]
        public void TestMethod0()
        {
            // Arrange
            string input = "abc";
            var expected = new string[] {"a:c"};

            RunTest(input, expected);
        }

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string input = ""; 
            var expected = new string[0];

            RunTest(input, expected);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            string input = "  ";
            var expected = new string[0];

            RunTest(input, expected);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            string input = "aha";
            var expected = new string[] { "a:a", "h:h" };

            RunTest(input, expected);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            string input = "xyzzy";
            var expected = new string[] { "x:z" };

            RunTest(input, expected);
        }

        [TestMethod]
        public void TestMethod5()
        {
            // Arrange
            string input = "and toto too";
            var expected = new string[] { "a:a", "d:d", "n:o", "t:t" };

            RunTest(input, expected);
        }

        [TestMethod]
        public void TestMethod6()
        {
            // Arrange
            string input = "topcoder quiz";
            var expected = new string[] { "c:e", "i:i", "o:r", "t:u", "z:z" };

            RunTest(input, expected);
        }

        [TestMethod]
        public void TestMethod7()
        {
            // Arrange
            string input = "the quick brown fox jumps over the lazy dog";
            var expected = new string[] { "a:z" };

            RunTest(input, expected);
        }

        private static void RunTest(string input, string[] expected)
        {
            // Act 
            var letterRange = new LetterRange();
            string[] actual = letterRange.ranges(input);

            // Assert
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
