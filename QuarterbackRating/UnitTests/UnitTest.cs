
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuarterbackRating.Data;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CanReadAllQuarterbacks()
        {
            var repo = new QuarterbackRepo();
            var quarterbacks = repo.ReadAll();

            Assert.AreEqual(5, quarterbacks.Count);
            Assert.AreEqual(2, quarterbacks[1].Id);
            Assert.AreEqual("Lamar Jackson", quarterbacks[1].Name);
            Assert.AreEqual(117, quarterbacks[1].PassAttempts);
            Assert.AreEqual(76, quarterbacks[1].PassCompletions);
            Assert.AreEqual(893, quarterbacks[1].PassingYards);
            Assert.AreEqual(11, quarterbacks[1].Touchdowns);
            Assert.AreEqual(4, quarterbacks[1].Interceptions);
            Assert.AreEqual(105.1M, quarterbacks[1].Rating);
        }
    }
}
