using QuarterbackRating.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuarterbackRating.Core.Services
{
    public class RatingCalculator
    {
        public decimal CalculateWeightedCompletionPercentage(int passCompletions, int passAttempts)
        {
            var completions = Convert.ToDecimal(passCompletions);
            var attempts = Convert.ToDecimal(passAttempts);
            var points = 0.0M;
            points = (completions / attempts) * 100;
            points -= 30;
            points = points * 0.05M;

            if (points < 0)
            {
                points = 0;
            }
            else if (points > 2.375M)
            {
                points = 2.375M;
            }

            points = Decimal.Round(points, 3);

            return points;
        }

        public decimal CalculateWeightedYardsPerAttempt(int passingYards, int passAttempts)
        {
            var yards = Convert.ToDecimal(passingYards);
            var attempts = Convert.ToDecimal(passAttempts);
            var points = 0.0M;
            points = yards / attempts;
            points -= 3;
            points = points * 0.25M;

            if (points < 0)
            {
                points = 0;
            }
            else if (points > 2.375M)
            {
                points = 2.375M;
            }

            points = Decimal.Round(points, 3);

            return points;
        }

        public decimal CalculateWeightedPercentageOfTouchdownPasses(int touchdowns, int passAttempts)
        {
            var tds = Convert.ToDecimal(touchdowns);
            var attempts = Convert.ToDecimal(passAttempts);
            var points = 0.0M;
            points = (tds / attempts) * 100;
            points = points * 0.2M;

            if (points > 2.375M)
            {
                points = 2.375M;
            }

            points = Decimal.Round(points, 3);

            return points;
        }

        public decimal CalculateWeightedPercentageOfInterceptions(int interceptions, int passAttempts)
        {
            var ints = Convert.ToDecimal(interceptions);
            var attempts = Convert.ToDecimal(passAttempts);
            var points = 0.0M;
            points = (ints / attempts) * 100;
            points = points * 0.25M;
            points = 2.375M - points;

            if (points < 0)
            {
                points = 0;
            }

            points = Decimal.Round(points, 3);

            return points;
        }

        public decimal CalculateRating(Quarterback quarterback)
        {
            var compPoints = CalculateWeightedCompletionPercentage(quarterback.PassCompletions, quarterback.PassAttempts);
            var yardPoints = CalculateWeightedYardsPerAttempt(quarterback.PassingYards, quarterback.PassAttempts);
            var tdPoints = CalculateWeightedPercentageOfTouchdownPasses(quarterback.Touchdowns, quarterback.PassAttempts);
            var intPoints = CalculateWeightedPercentageOfInterceptions(quarterback.Interceptions, quarterback.PassAttempts);
            var finalPoints = 0.0M;
            finalPoints = compPoints + yardPoints + tdPoints + intPoints;
            finalPoints = (finalPoints / 6) * 100;

            finalPoints = Decimal.Round(finalPoints, 1);

            return finalPoints;
        }
    }
}
