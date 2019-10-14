﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    /// <summary>Manages the movies in a database.</summary>
    public class MovieDatabase
    {
        public MovieDatabase ()
        {
            //Collection initializer
            _movies = new List<Movie> () {
                new Movie () {Id = ++_id, Title = "Jaws",     ReleaseYear = 1979, Rating = "PG",},
                new Movie () {Id = ++_id, Title = "StarWars", ReleaseYear = 1977, Rating = "PG",},
                new Movie () {Id = ++_id, Title = "Distance", ReleaseYear = 1989, Rating = "PG",},
                new Movie () {Id = ++_id, Title = "Spy Kids", ReleaseYear = 1999, Rating = "PG-13",}
            };
        }
        public Movie Add ( Movie movie )
        {
            //TODO: Validation
            if (movie == null)
                return null;
            if (!String.IsNullOrEmpty (movie.Validate ()))
                return null;

            //Name must be unique
            var existing = FindMovie (movie.Title);
            if (existing != null)
                return null;

            //Add movie
            movie.Id = ++_id;

            var newMovie = Clone (new Movie (), movie);
            _movies.Add (movie);

            return movie;
        }

        public void Remove ( int id )
        {
            var movie = FindMovie (id);
            if (movie != null)
                _movies.Remove (movie);
        }

        public Movie Get (int id)
        {
            //Validate
            if (id <= 0)
                return null;

            var movie = FindMovie (id);
            return movie != null ? Clone (new Movie (), movie) : null;
        }

        public Movie[] GetAll ()
        {
            var index = 0;
            var movies = new Movie[_movies.Count];
            foreach (var movie in _movies)
                if (movie != null)
                    movies[index++] = Clone (new Movie (), movie);

            return movies;
        }

        public void Update ( int id, Movie newMovie )
        {
            //Validate
            if (id <= 0)
                return;
            if (newMovie == null)
                return;
            if (!String.IsNullOrEmpty (newMovie.Validate ()))
                return;

            //Must be unique
            var existing = FindMovie (newMovie.Title);
            if (existing != null && existing.Id != id)
                return;

            existing = FindMovie (id);
            if (existing == null)
                return; //TODO: Error

            //Update existing movie
            newMovie.Id = id; 
            Clone (existing, newMovie);
        }

        private Movie Clone ( Movie target, Movie source )
        {
            target.Id = source.Id;
            target.Description = source.Description;
            target.HasSeen = source.HasSeen;
            target.Rating = source.Rating;
            target.ReleaseYear = source.ReleaseYear;
            target.RunLength = source.RunLength;
            target.Title = source.Title;

            return target;
        }

        private Movie FindMovie ( int id )
        {
            foreach (var movie in _movies)
                if (movie.Id == id)
                    return movie;

            return null;
        }

        private Movie FindMovie ( string name )
        {
            foreach (var movie in _movies)
                if (String.Compare(movie.Title, name, true) == 0)
                    return movie;

            return null;
        }
        //private Movie[] _movies = new Movie[100];
        //Dynamically resizing array
        private List<Movie> _movies = new List<Movie> ();

        //Identical to List<T>, just wrong namespace
        // using System.Collections.ObjectModel;
        //private Collection<Movie> _movies = new Collection<Movie>();
        private int _id = 0;
    }
}
