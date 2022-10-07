using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarterbackRating.Utility
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

        public decimal CalculateWeightedYardsPerAttempt()
        {
            throw new Exception();
        }

        public decimal CalculateWeightedPercentageOfTouchdownPasses()
        {
            throw new Exception();
        }

        public decimal CalculateWeightedPercentageOfInterceptions()
        {
            throw new Exception();
        }

        public decimal CalculateRating()
        {
            throw new Exception();
        }
    }
}
