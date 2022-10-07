
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuarterbackRating.Data;
using QuarterbackRating.Models;
using QuarterbackRating.Utility;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CanCreateQuarterback()
        {
            var quarterback = new Quarterback();
            quarterback.Name = "Jalen Hurts";
            quarterback.PassAttempts = 123;
            quarterback.PassCompletions = 82;
            quarterback.PassingYards = 1120;
            quarterback.Touchdowns = 4;
            quarterback.Interceptions = 2;

            var repo = new QuarterbackRepo();
            repo.Create(quarterback);

            var quarterbacks = repo.ReadAll();

            Assert.AreEqual(6, quarterbacks.Count);
            Assert.AreEqual(6, quarterbacks[5].Id);
            Assert.AreEqual("Jalen Hurts", quarterbacks[5].Name);
            Assert.AreEqual(123, quarterbacks[5].PassAttempts);
            Assert.AreEqual(82, quarterbacks[5].PassCompletions);
            Assert.AreEqual(1120, quarterbacks[5].PassingYards);
            Assert.AreEqual(4, quarterbacks[5].Touchdowns);
            Assert.AreEqual(2, quarterbacks[5].Interceptions);
            Assert.AreEqual(99.6M, quarterbacks[5].Rating);
        }

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

        [TestMethod]
        public void CanUpdateQuarterback()
        {
            var repo = new QuarterbackRepo();

            var originalQuarterback = repo.ReadbyId(1);
            var updatedQuarterback = originalQuarterback;
            updatedQuarterback.PassAttempts = 461;
            updatedQuarterback.PassCompletions = 324;
            updatedQuarterback.PassingYards = 3969;
            updatedQuarterback.Touchdowns = 35;
            updatedQuarterback.Interceptions = 10;

            repo.Update(updatedQuarterback);

            var quarterback = repo.ReadbyId(1);

            Assert.AreEqual(1, quarterback.Id);
            Assert.AreEqual("Kirk Cousins", quarterback.Name);
            Assert.AreEqual(461, quarterback.PassAttempts);
            Assert.AreEqual(324, quarterback.PassCompletions);
            Assert.AreEqual(3969, quarterback.PassingYards);
            Assert.AreEqual(35, quarterback.Touchdowns);
            Assert.AreEqual(10, quarterback.Interceptions);
            Assert.AreEqual(112.8M, quarterback.Rating);
        }

        [TestMethod]
        public void CanDeleteQuarterback()
        {
            var repo = new QuarterbackRepo();
            var quarterback = repo.ReadbyId(6);

            Assert.IsNotNull(quarterback);

            repo.Delete(quarterback);

            var quarterbacks = repo.ReadAll();
            quarterback = repo.ReadbyId(6);

            Assert.AreEqual(5,quarterbacks.Count);
            Assert.IsNull(quarterback);
        }

        [TestMethod]
        public void CanCalculateWeightedCompletionPercentage()
        {
            var passCompletions = 324;
            var passAttempts = 461;

            var calc = new RatingCalculator();
            var points = calc.CalculateWeightedCompletionPercentage(passCompletions, passAttempts);

            Assert.AreEqual(2.014M, points);
        }

        [TestMethod]
        public void CanCalculateWeightedYardsPerAttempt()
        {
            var passingYards = 3969;
            var passAttempts = 461;

            var calc = new RatingCalculator();
            var points = calc.CalculateWeightedYardsPerAttempt(passingYards, passAttempts);

            Assert.AreEqual(1.402M, points);
        }

        [TestMethod]
        public void CanCalculateWeightedPercentageOfTouchdownPasses()
        {
            var touchdowns = 35;
            var passAttempts = 461;

            var calc = new RatingCalculator();
            var points = calc.CalculateWeightedPercentageOfTouchdownPasses(touchdowns, passAttempts);

            Assert.AreEqual(1.518M, points);
        }

        [TestMethod]
        public void CanCalculateWeightedPercentageOfInterceptions()
        {
            var touchdowns = 10;
            var passAttempts = 461;

            var calc = new RatingCalculator();
            var points = calc.CalculateWeightedPercentageOfInterceptions(touchdowns, passAttempts);

            Assert.AreEqual(1.833M, points);
        }

        [TestMethod]
        public void CanCalculateRating()
        {
            var quarterback = new Quarterback();
            quarterback.Name = "Steve Young";
            quarterback.PassAttempts = 461;
            quarterback.PassCompletions = 324;
            quarterback.PassingYards = 3969;
            quarterback.Touchdowns = 35;
            quarterback.Interceptions = 10;

            var calc = new RatingCalculator();
            quarterback.Rating = calc.CalculateRating(quarterback);

            Assert.AreEqual(112.8M, quarterback.Rating);
        }
    }
}
