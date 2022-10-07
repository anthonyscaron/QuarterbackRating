using QuarterbackRating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarterbackRating.Data
{
    public class QuarterbackRepo
    {
        private static List<Quarterback> _quarterbacks = new List<Quarterback>
        {
            new Quarterback {Id=1, Name="Steve Young", PassAttempts=461, PassCompletions=324, PassingYards=3969, Touchdowns=35, Interceptions=10, Rating=112.8M}
        };

        public List<Quarterback> ReadAll()
        {
            return _quarterbacks;
        }
    }
}
