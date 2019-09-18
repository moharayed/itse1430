using System;
using System.Windows.Forms;

namespace Itse1430.MovieLib.Host
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            //int x = 10;
            InitializeComponent ();

            //itse1430.MovieLib.Movie
            Movie movie = new Movie ();
            movie.title = "Jaws";
            movie.description = movie.title;
        }

        //Called when Movie\Add selected
        private void AddToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            var form = new MovieForm ();

            //Modeless - does not block main window
            //form.Show ();

            // Show the new movie from modally
            if (form.ShowDialog (this) == DialogResult.OK)

                //TODO: Save it
                _movie = form.Movie;
        }

        private Movie _movie;
    }
}
