
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuarterbackRating.Data;
using QuarterbackRating.Models;

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

        [TestMethod]
        public void CanReadByIdQuarterback()
        {
            var id = 1;
            var repo = new QuarterbackRepo();
            var quarterback = repo.ReadbyId(id);

            Assert.AreEqual(1, quarterback.Id);
            Assert.AreEqual("Kirk Cousins", quarterback.Name);
            Assert.AreEqual(157, quarterback.PassAttempts);
            Assert.AreEqual(99, quarterback.PassCompletions);
            Assert.AreEqual(1031, quarterback.PassingYards);
            Assert.AreEqual(6, quarterback.Touchdowns);
            Assert.AreEqual(4, quarterback.Interceptions);
            Assert.AreEqual(84.1M, quarterback.Rating);
        }

        /* [TestMethod]
        public void CanCreateQuarterback()
        {
            var quarterback = new Quarterback();
            quarterback.Name = "Jalen Hurts";
            quarterback.PassAttempts = 123;
            quarterback.PassCompletions = 82;
            quarterback.PassingYards = 1120;
            quarterback.Touchdowns = 4;
            quarterback.Interceptions = 2;
        } */
    }
}
