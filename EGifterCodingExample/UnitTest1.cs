using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatchClass;

namespace EGifterCodingExample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string testInput = "()()()";

            Match match = new Match();

            Assert.AreEqual(true, match.DoMatch(testInput));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string testInput = ")(";

            Match match = new Match();

            Assert.AreEqual(false, match.DoMatch(testInput));
        }

        [TestMethod]
        public void TestMethod3()
        {
            string testInput = "(((())())";

            Match match = new Match();

            Assert.AreEqual(false, match.DoMatch(testInput));
        }


        [TestMethod]
        public void TestMethod4()
        {
            string testInput = "((45+)*a3)";

            Match match = new Match();

            Assert.AreEqual(true, match.DoMatch(testInput));
        }
    }
}
