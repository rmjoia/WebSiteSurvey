using System.Collections.Generic;
using System.Linq;

namespace WebSiteSurvey.Models
{
    public class ReportModel
    {
        public ReportModel(IEnumerable<int> ratings, IEnumerable<int> ages, IEnumerable<string> genders,
            IEnumerable<string> countries)
        {
            Ratings = ratings;
            Ages = ages;
            Genders = genders;
            Countries = countries;
        }

        private IEnumerable<int> Ratings { get; }
        private IEnumerable<int> Ages { get; }
        private IEnumerable<string> Genders { get; }
        private IEnumerable<string> Countries { get; }

        public double GetAverageAge()
        {
            return Ages.Average();
        }

        public double GetAverageRate()
        {
            return Ratings.Average();
        }

        public Dictionary<string, int> GetGenderDistribution()
        {
            return GetDistribution(Genders);
        }

        public Dictionary<string, int> GetCountryDistribution()
        {
            return GetDistribution(Countries);
        }

        public int GetTotalSubmissions()
        {
            return Ages.Count();
        }

        private Dictionary<string, int> GetDistribution(IEnumerable<string> collection)
        {
            var groups = collection.GroupBy(g => g)
                .Select(g => new {Item = g.Key, Count = g.Count()});

            return groups.ToDictionary(g => g.Item, g => g.Count);
        }
    }
}