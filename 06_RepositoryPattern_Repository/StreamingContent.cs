using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    /*
        Users have been complaining about their family friendly content. Some users have been reporting that when filtering for family friendly, they're getting some content with inappropriate maturity ratings. We need to fix this. Currently the maturity rating and family friendly bool are independent, we need to tie them together. If something is rated R (or another similar rating), it should never be able to have a IsFamilyFriendly of true. 

        We need you to refactor the code StreamingContent class. To help narrow down our problem, we want to replace the MaturityRating with a default set of options. Based on those options, we want our IsFamilyFriendly to return the appropriate true or false.

        make a maturity rating enum with default options (constants)
        update IsFamilyFriendly to use the Getter and the Maturity Rating
    */


    // POCO
    // Plain Old C# Object
    public class StreamingContent
    {
        // Constructors
        public StreamingContent() { }
        public StreamingContent(string title, string description, MaturityRating maturityRating, double starRating, int releaseYear, GenreType genre)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            ReleaseYear = releaseYear;
            Genre = genre;
        }

        // Properties
        public string Title { get; set; }
        public string Description { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public double StarRating { get; set; }
        public int ReleaseYear { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                // Casting
                return (int)MaturityRating < 3;

                // Figure out if it is Family Friendly and return true or false
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_Y:
                        return true;
                    default:
                        return false;
                }
            }
        }
        public GenreType Genre { get; set; }
    }

    public enum MaturityRating
    {
        G, PG, TV_Y, PG13, R, NC17, TV_PG, TV_14, TV_MA
    }

    public enum GenreType
    {
        ActionAdventure,
        Action,
        Thriller,
        Horror,
        Comedy,
        Bromance,
        Mystery,
        SciFi
    }
}
