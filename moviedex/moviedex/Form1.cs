using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moviedex
{
    enum genre
    {
        Horror, Action, Comedy, Thriller, Drama, Romance
    }
    enum rating
    {
        G, PG, pg13, tv14, R
    }
    struct movie
    {
        public string title;
        public string director;
        public string actor;
        public genre genretype;
        public rating ratingtype;
        public int score;
        public string revenue;
        public string image;
    }

    public partial class Form1 : Form
    {
        private int current;
        private int count;
        private movie[] movies;

        public Form1()
        {
            InitializeComponent();
            current = 0;
            count = 0;
            currentlabel.Text = current.ToString();
            movies = new movie[50];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("movie.txt"))
            {
                StreamReader inFile = new StreamReader("movie.txt");
                while (!inFile.EndOfStream)
                {
                    string s = inFile.ReadLine();
                    movie p = readmovie(s);
                    movies[count] = p;
                    count++;
                }
                inFile.Close();
                showmovie(movies[0]);
            }
        }
        private movie readmovie(string s)
        {
            movie p = new movie();
            string[] fields = s.Split('|');
            p.title = fields[0];
            p.director = fields[1];
            p.actor = fields[2];
            p.genretype = (genre)Enum.Parse(typeof(genre), fields[3]);
            p.ratingtype = (rating)Enum.Parse(typeof(rating), fields[4]);
            p.score = int.Parse(fields[5]);
            p.revenue = fields[6];
            p.image = fields[7];
            return p;
        }
        private void showmovie(movie p)
        {
            titletextBox.Text = p.title;
            directortextBox.Text = p.director;
            actortextBox.Text = p.actor;
            genrecomboBox.Text = p.genretype.ToString();
            ratingcomboBox.Text = p.ratingtype.ToString();
            scoreUpDown.Value = p.score;
            revenuetextBox.Text = p.revenue;
            posterpictureBox.ImageLocation = p.image;
        }
        private void save()
        {
            string tmp = " ";
            tmp += titletextBox.Text;
            tmp += "|";
            tmp += directortextBox.Text;
            tmp += "|";
            tmp += actortextBox.Text;
            tmp += "|";
            tmp += genrecomboBox.Text;
            tmp += "|";
            tmp += ratingcomboBox.Text;
            tmp += "|";
            tmp += scoreUpDown.Value;
            tmp += "|";
            tmp += revenuetextBox.Text;
            tmp += "|";
            tmp += posterpictureBox.ImageLocation;
            movies[current] = readmovie(tmp);

            StreamWriter outifle = new StreamWriter("movie.txt");
            for (int i = 0; i < count; i++)
            {
                outifle.WriteLine(movieToString(movies[i]));
            }
            outifle.Close();
        }
        private string movieToString(movie p)
        {
            string retVal = " ";
            retVal += p.title.ToString();
            retVal += "|";
            retVal += p.director.ToString();
            retVal += "|";
            retVal += p.actor.ToString();
            retVal += "|";
            retVal += p.genretype.ToString();
            retVal += "|";
            retVal += p.ratingtype.ToString();
            retVal += "|";
            retVal += p.score.ToString();
            retVal += "|";
            retVal += p.revenue.ToString();
            retVal += "|";
            retVal += p.image.ToString();
            return retVal;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            save();
        }

        private void firstbutton_Click(object sender, EventArgs e)
        {
            save();
            current = 0;
            currentlabel.Text = current.ToString();
            showmovie(movies[current]);
        }

        private void lastbutton_Click(object sender, EventArgs e)
        {
            save();
            current = count - 1;
            currentlabel.Text = current.ToString();
            showmovie(movies[current]);
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            if (current > 0)
            {
                save();
                current -= 1;
                currentlabel.Text = current.ToString();
                showmovie(movies[current]);
            }
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            if (current < count - 1)
            {
                save();
                current++;
                currentlabel.Text = current.ToString();
                showmovie(movies[current]);
            }
        }
        private void clear()
        {
            titletextBox.Text = " ";
            directortextBox.Text = " ";
            actortextBox.Text = " ";
            genrecomboBox.Text = " ";
            ratingcomboBox.Text = " ";
            scoreUpDown.Value = 0;
            revenuetextBox.Text = " ";
            posterpictureBox.Image = null;
        }

        private void newbutton_Click(object sender, EventArgs e)
        {
            current = count;
            count++;
            clear();
        }

        private void posterpictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            posterpictureBox.Load(openFileDialog1.FileName);
        }
    }
}
