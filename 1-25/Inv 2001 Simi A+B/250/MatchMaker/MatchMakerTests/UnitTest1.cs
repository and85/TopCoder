using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace MatchMakerTests
{
    [TestClass]
    public class UnitTest1
    {
        private string[] _members = new string[]  {    
                                                    "BETTY F M A A C C",
                                                    "TOM M F A D C A",
                                                    "SUE F M D D D D",
                                                    "ELLEN F M A A C A",
                                                    "JOE M F A A C A",
                                                    "ED M F A D D A",
                                                    "SALLY F M C D A B",
                                                    "MARGE F M A A C C"
                                                };

        [TestMethod]
        public void TestMethod0()
        {
            // Assert
            string[] expected = new string[] { "JOE", "TOM" };

            
            string currentUserName = "BETTY";
            int sf = 2;

            RunTest(expected, currentUserName, sf);
        }

        [TestMethod]
        public void TestMethod1()
        {
            // Assert
            string[] expected = new string[] { "ELLEN", "BETTY", "MARGE" };


            string currentUserName = "JOE";
            int sf = 1;

            RunTest(expected, currentUserName, sf);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Assert
            string[] expected = new string[] { };


            string currentUserName = "MARGE";
            int sf = 4;

            RunTest(expected, currentUserName, sf);
        }

        private void RunTest(string[] expected, string currentUserName, int sf)
        {
            // Act
            var matchMaker = new MatchMaker();
            string[] actual = matchMaker.getBestMatches(_members, currentUserName, sf);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
