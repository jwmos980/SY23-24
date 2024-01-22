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
        public string name;
        public string type;
        public int level;
        public attack attacktype;
        public int hp;
        public int xp;
        public bool legendary;
        public bool shiny;
        public int generation;
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
                readpokemon(s);
                inFile.Close();
            }
        }
        private void readpokemon(string s)
        {
            pokemon p = new pokemon();
            string[] fields = s.Split('|');
            p.name = fields[0];
            p.type = fields[1];
            p.level = int.Parse(fields[2]);
            p.attacktype = (attack)Enum.Parse(typeof(attack), fields[3]);
            p.hp = int.Parse(fields[4]);
            p.xp = int.Parse(fields[5]);
            if (fields[6] == "true")
                p.legendary = true;
            else
                p.legendary = false;
            if (fields[7] == "true")
                p.shiny = true;
            else
                p.shiny = false;
            p.generation = int.Parse(fields[8]);

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
