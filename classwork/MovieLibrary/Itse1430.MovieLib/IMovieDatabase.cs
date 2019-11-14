using System.Collections.Generic;

namespace Itse1430.MovieLib
{
    /// <summary>Provides a database of movies.</summary>
    public interface IMovieDatabase
    {
        /// <summary>Add a movie.</summary>
        /// <param name="movie">The movie to add.</param>
        /// <returns>The new movie.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="movie"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="movie"/> is not unique.</exception>
        /// <exception cref="ValidationException"><paramref name="movie"/> is invalid.</exception>
        Movie Add ( Movie movie );

        /// <summary>Gets a movie.</summary>
        /// <param name="id">The ID of the movie.</param>
        /// <returns>The movie, if any.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to zero.</exception>
        Movie Get ( int id );

        /// <summary>Gets all movies.</summary>
        /// <returns>Returns the movies.</returns>
        IEnumerable<Movie> GetAll ();

        /// <summary>Removes a movie.</summary>
        /// <param name="id">The ID of the movie.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to zero.</exception>
        void Remove ( int id );

        /// <summary>Updates a movie.</summary>
        /// <param name="id">The ID of the movie.</param>
        /// <param name="movie">The updated movie.</param>
        /// <exception cref="ArgumentNullException"><paramref name="movie"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to zero.</exception>
        /// <exception cref="ArgumentException"><paramref name="movie"/> is not unique.</exception>
        /// <exception cref="ValidationException"><paramref name="movie"/> is invalid.</exception>
        void Update ( int id, Movie movie );
    }
}
/* 
 * System Exception important
 * 1)NREX
 * 2)OutofmemoryEX
 * 3)StackoverflowEX
*/
