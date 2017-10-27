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
    }
}
