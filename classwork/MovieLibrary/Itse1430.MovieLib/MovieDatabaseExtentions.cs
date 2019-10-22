using System;

namespace Itse1430.MovieLib
{
    public static class MovieDatabaseExtentions
    {
        public static void Seed ( IMovieDatabase database )
        {
            database.Add (new Movie () {Title = "Jaws",     ReleaseYear = 1979, Rating = "PG", });
            database.Add (new Movie () {Title = "StarWars", ReleaseYear = 1977, Rating = "PG", });
            database.Add (new Movie () {Title = "Distance", ReleaseYear = 1989, Rating = "PG", });
            database.Add (new Movie () {Title = "Spy Kids", ReleaseYear = 1999, Rating = "PG-13", });
            
        }
    }
}
