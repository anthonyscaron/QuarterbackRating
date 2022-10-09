using QuarterbackRating.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarterbackRating.Core.Services
{
    public class QuarterbackRepository
    {
        private static List<Quarterback> _quarterbacks = new List<Quarterback>
        {
            new Quarterback {Id=1, Name="Kirk Cousins", PassAttempts=157, PassCompletions=99, PassingYards=1031, Touchdowns=6, Interceptions=4, Rating=84.1M},
            new Quarterback {Id=2, Name="Lamar Jackson", PassAttempts=117, PassCompletions=76, PassingYards=893, Touchdowns=11, Interceptions=4, Rating=105.1M},
            new Quarterback {Id=3, Name="Tom Brady", PassAttempts=155, PassCompletions=106, PassingYards=1058, Touchdowns=6, Interceptions=1, Rating=97.7M},
            new Quarterback {Id=4, Name="Patrick Mahomes", PassAttempts=146, PassCompletions=97, PassingYards=1106, Touchdowns=11, Interceptions=2, Rating=108.4M},
            new Quarterback {Id=5, Name="Justin Herbert", PassAttempts=166, PassCompletions=111, PassingYards=1250, Touchdowns=9, Interceptions=2, Rating=102.2M}
        };

        public void Create(Quarterback quarterback)
        {
            var calc = new RatingCalculator();

            quarterback.Id = _quarterbacks.Max(q => q.Id) + 1;
            quarterback.Rating = calc.CalculateRating(quarterback);
            _quarterbacks.Add(quarterback);
        }

        public static List<Quarterback> ReadAll()
        {
            return _quarterbacks.OrderBy(q => q.Name).ToList();
        }

        public static Quarterback ReadbyId(int id)
        {
            var quarterback = _quarterbacks.FirstOrDefault(q => q.Id == id);
            return quarterback;
        }

        public void Update(Quarterback quarterback)
        {
            var calc = new RatingCalculator();

            var quarterbackToUpdate = _quarterbacks.FirstOrDefault(q => q.Id == quarterback.Id);
            quarterback.Rating = calc.CalculateRating(quarterback);
            quarterbackToUpdate = quarterback;
        }

        public void Delete(Quarterback quarterback)
        {
            var quarterbackToDelete = _quarterbacks.FirstOrDefault(q => q.Id == quarterback.Id);
            _quarterbacks.Remove(quarterbackToDelete);
        }

        public static async Task<IEnumerable<Quarterback>> GetDataAsync()
        {
            await Task.CompletedTask;
            return ReadAll();
        }
    }
}
