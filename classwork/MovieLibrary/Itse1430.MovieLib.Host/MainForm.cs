using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Itse1430.MovieLib.Host
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent ();
        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad (e);

            //Seed movies
            _movies = new MemoryMovieDatabase ();
            var count = _movies.GetAll ().Count ();
            if (count == 0)
                MovieDatabaseExtentions.Seed (_movies);

            UpdateUI ();
        }

        //Called when Movie\Add selected
        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var form = new MovieForm ();

            //Modeless - does not block main window
            //form.Show();

            //Show the new movie form modally
            if (form.ShowDialog (this) == DialogResult.OK)
            {
                _movies.Add (form.Movie);
                UpdateUI ();
            };
        }

        private Movie GetSelectedMovie ()
        {
            //return _lstMovies.SelectedItem as Movie;
            var item = _lstMovies.SelectedItem;
            //if (item == null)
            //    return null;

            //Movie or null
            return item as Movie;

            ////Other approaches
            ////C-style cast
            //(Movie)item;

            ////Old approach 1
            //var tempVar = item as Movie;
            //if (tempVar != null)
            //{
            //};

            ////Old approach 2
            //if (item is Movie)
            //{
            //    var i = (Movie)item;
            //    //Do something with movie
            //}

            ////Pattern Matching
            //if (item is Movie movie)
            //{
            //};
        }

        private void OnMovieEdit ( object sender, EventArgs e )
        {
            //Get selected movie
            var movie = GetSelectedMovie ();
            if (movie == null)
                return;

            var form = new MovieForm ();
            form.Movie = movie;

            if (form.ShowDialog (this) == DialogResult.OK)
            {
                _movies.Update (movie.Id, form.Movie);
                UpdateUI ();

                // //TODO: Change to update
                // _movies.Remove(movie);
                //// RemoveMovie (form.Movie);
                // _movies.Add (form.Movie);
                // UpdateUI ();
            };
        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {
            #region Playing with null
            //var menuItem = sender as Button;
            ////This will crash if menuItem is null
            ////var text = menuItem.Text;

            ////Handle null - as statement
            //var text = "";
            //if (menuItem != null)
            //    text = menuItem.Text;
            //else
            //    text = "";

            ////As expression
            //var text2 = (menuItem != null) ? menuItem.Text : "";

            ////Null coalescing menuItem ?? "";
            ////Null conditional operator
            //var text3 = menuItem?.Text ?? "";
            #endregion

            var movie = GetSelectedMovie ();
            if (movie == null)
                return;

            //Confirmation
            var msg = $"Are you sure you want to delete {movie.Title}?";
            var result = MessageBox.Show (msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            //Delete it
            _movies.Remove (movie.Id);
            UpdateUI ();
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close ();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm ();
            form.ShowDialog (this);
        }

        private void UpdateUI ()
        {
            var movies = _movies.GetAll ();

            //Programmatic approach
            //_lstMovies.Items.Clear();
            //_lstMovies.Items.AddRange(movies);

            //For more complex bindings
            _lstMovies.DataSource = movies.ToArray();
        }

        //private void AddMovie ( Movie movie )
        //{
        //    _movies.Add (movie);

        //    ////Add to array
        //    //for (var index = 0; index < _movies.Count; ++index)
        //    //{
        //    //    if (_movies[index] == null) - Section 2 stuff
        //    //    {
        //    //        _movies[index] = movie;
        //    //        return;
        //    //    };
        //    //};
        //}

        //private void RemoveMovie ( Movie movie )
        //{
        //    _movies.Remove (movie);
        //    ////Remove from array
        //    //for (var index = 0; index < _movies.Count; ++index)
        //    //{
        //    //    //This won't work
        //    //    if (_movies[index] == movie) - Section 2 stuff
        //    //    {
        //    //        _movies[index] = null;
        //    //        return;
        //    //    };
        //    //};
        //}

        //private Movie[] GetMovies ()
        //{
        //    ////Filter out empty movies
        //    //var count = 0;
        //    //foreach (var movie in _movies) - Section 2 stuff
        //    //    if (movie != null)
        //    //        ++count;

        //    var index = 0;
        //    var movies = new Movie[_movies.Count];
        //    foreach (var movie in _movies)
        //        if (movie != null)
        //            movies[index++] = movie;

        //    return movies;
        //}

        //private Movie[] _movies = new Movie[100]; - used for project 2

        private IMovieDatabase _movies;
    }
}
