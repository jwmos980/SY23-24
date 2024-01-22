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

namespace pokedex
{
    enum attack
    {
        special_attack, special_defense 
    }
    struct pokemon
    {
        string name;
        string type;
        int level;
        attack attacktype;
        int hp;
        int xp;
        bool legendary;
        bool shiny;
        int generation;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("pokemon.txt"))
            {
            StreamReader inFile = new StreamReader("pokemon.txt");
                string s = inFile.ReadToEnd();
                inFile.Close();
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            debugBox.Clear();

            debugBox.Text += nametextBox.Text;
            debugBox.Text += "|"; 
            debugBox.Text += typetextBox.Text;
            debugBox.Text += "|";
            debugBox.Text += levelnumericUpDown.Value;
            debugBox.Text += "|";
            debugBox.Text += attacknumericUpDown.Value;
            debugBox.Text += "|";
            debugBox.Text += hpnumericUpDown.Value;
            debugBox.Text += "|";
            debugBox.Text += xpnumericUpDown.Value;
            debugBox.Text += "|";
            debugBox.Text += legendarycheckBox.Checked;
            debugBox.Text += "|";
            debugBox.Text += shinycheckBox.Checked;
            debugBox.Text += "|";
            debugBox.Text += generationnumericUpDown.Value;

            StreamWriter outifle = new StreamWriter("pokemon.txt");
            outifle.Write(debugBox.Text);
            outifle.Close();
        }
    }
}
