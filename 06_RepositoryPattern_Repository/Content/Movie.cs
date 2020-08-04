using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository.Content
{
    public class Movie : StreamingContent
    {
        public Movie() : base() { }
        public Movie(string title, string description, MaturityRating maturityRating, double starRating, int releaseYear, GenreType genre, double runTime)
            : base(title, description, maturityRating, starRating, releaseYear, genre)
        {
            RunTime = runTime;
        }

        // Minutes
        public double RunTime { get; set; }
    }
}
