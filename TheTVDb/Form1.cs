using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;





namespace TheTVDb
{
    public partial class InfoGrabber : Form
    {
        /// <summary>
        /// Currently got everything working except the file menu buttons.
        /// Current version: Alpha 2.3
        /// Creator: Warzone (Joel Parkinson)
        /// </summary>
        private const string APIKey = "630abcbc6e2239281d940e64c816e716";
        private int _i;
        public TMDbClient client = new TMDbClient(APIKey);

        public InfoGrabber()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _i = 0;
            string _info = info.Text;
            var regex = new Regex("Id:(.*?)::");
            Match selected = regex.Match(movie_Id.Text);
            string id = selected.Groups[1].ToString();
            try
            {
                Movie movie = client.GetMovie(id, MovieMethods.Trailers | MovieMethods.Undefined |
                                                  MovieMethods.Credits | MovieMethods.Images);
                bbcode.AppendText(string.Format("[center][title=purple]{0}[/title]\n\n",
                    releaseName.Text));
                bbcode.AppendText(
                    string.Format("[img]https://image.tmdb.org/t/p/w396{0}[/img][/center]\n[icon=info3]\n{1}\n",
                        movie.Images.Posters[0].FilePath, _info));

                bbcode.AppendText(string.Format("[icon=plot3]\n"));
                string plot = movie.Overview;
                bbcode.AppendText(string.Format("{0}\n", plot));
                bbcode.AppendText(string.Format("[icon=cast3]\n"));
                for (_i = 0; _i <= 10; _i++)
                {
                    try
                    {
                        List<Cast> cast = movie.Credits.Cast;
                        bbcode.AppendText(string.Format("[b]{0}[/b]: [b][color=grey]{1}[/color][/b]\n",
                            cast[_i].Name, cast[_i].Character));
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        _i = 11;
                        MessageBox.Show(string.Format(
                            "No Cast Currently Found for {0}, Results of generator may be wrong!", movie.Title));
                        bbcode.AppendText(string.Format("None Found!\n\n"));
                    }
                }

                #region Image Checker
                if (img1.Text != "")
                {
                    bbcode.AppendText(string.Format("[icon=screens3]\n[img]{0}[/img]\n",img1.Text));
                }
                if (img2.Text != "")
                {
                    bbcode.AppendText(string.Format("[img]{0}[/img]\n", img2.Text));
                }
                if (img3.Text != "")
                {
                    bbcode.AppendText(string.Format("[img]{0}[/img]\n", img3.Text));
                }
                if (img4.Text != "")
                {
                    bbcode.AppendText(string.Format("[img]{0}[/img]\n", img4.Text));
                }
                if (img5.Text != "")
                {
                    bbcode.AppendText(string.Format("[img]{0}[/img]\n", img5.Text));
                }
                if (img6.Text != "")
                {
                    bbcode.AppendText(string.Format("[img]{0}[/img]\n", img6.Text));
                }
                if (img7.Text != "")
                {
                    bbcode.AppendText(string.Format("[img]{0}[/img]\n", img7.Text));
                }
                if (img8.Text != "")
                {
                    bbcode.AppendText(string.Format("[img]{0}[/img]\n", img8.Text));
                }
                #endregion
                
                try
                {
                    bbcode.AppendText(string.Format("[icon=trailer3]\n"));
                    bbcode.AppendText(string.Format("[video=http://www.youtube.com/watch?v={0}]\n\n",
                        movie.Trailers.Youtube[0].Source));
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show(string.Format("No Trailer currently Available for {0}", movie.Title));
                    bbcode.AppendText(string.Format("None Found!\n\n"));
                }
                bbcode.AppendText(string.Format("[center][title=purple]Enjoy - Warzone[/title][/center]"));
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(string.Format("No Movie Data Found!"));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            movie_Id.Items.Clear();
            try
            {
                SearchContainer<SearchMovie> results = client.SearchMovie(string.Format(txtb_Search.Text));
                foreach (SearchMovie result in results.Results)
                    movie_Id.Items.Add("Movie: " + result.OriginalTitle + "-     Id:" + result.Id + "::");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(string.Format("Don't forget to search for the movie you want data for!"));
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This is tempory
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}