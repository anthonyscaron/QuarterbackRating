using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarterbackRating.Models
{
    public class Quarterback
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PassAttempts { get; set; }
        public int PassCompletions { get; set; }
        public int PassingYards { get; set; }
        public int Touchdowns { get; set; }
        public int Interceptions { get; set; }
        public decimal Rating { get; set; }
    }
}
