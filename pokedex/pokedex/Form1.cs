using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        private int current;
        private int count;
        private pokemon[] pokemons;



        public Form1()
        {
            InitializeComponent();
            current = 0;
            count = 0;
            currentlabel.Text = current.ToString();
            pokemons = new pokemon[50];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("pokemon.txt"))
            {
            StreamReader inFile = new StreamReader("pokemon.txt");
                while (!inFile.EndOfStream)
                {
                    string s = inFile.ReadLine();
                    pokemon p = readpokemon(s);
                    pokemons[count] = p;
                    count++;
                }
                inFile.Close();
                showpokemon(pokemons[0]);
            }
        }

        private pokemon readpokemon(string s)
        {
            pokemon p = new pokemon();
            string[] fields = s.Split('|');
            p.name = fields[0];
            p.type = fields[1];
            p.level = int.Parse(fields[2]);
            p.attacktype = (attack)Enum.Parse(typeof(attack), fields[3]);
            p.hp = int.Parse(fields[4]);
            p.xp = int.Parse(fields[5]);
            if (fields[6] == "True")
                p.legendary = true;
            else   
                p.legendary = false;
            if (fields[7] == "True")
                p.shiny = true;
            else 
                p.shiny = false;
            p.generation = int.Parse(fields[8]);
            return p;
        }
        private void save()
        {
            string tmp = " ";
            tmp += nametextBox.Text;
            tmp += "|";
            tmp += typetextBox.Text;
            tmp += "|";
            tmp += levelnumericUpDown.Value;
            tmp += "|";
            tmp += attackcomboBox.Text;
            tmp += "|";
            tmp += hpnumericUpDown.Value;
            tmp += "|";
            tmp += xpnumericUpDown.Value;
            tmp += "|";
            tmp += legendarycheckBox.Checked;
            tmp += "|";
            tmp += shinycheckBox.Checked;
            tmp += "|";
            tmp += generationnumericUpDown.Value;
            pokemons[current] = readpokemon(tmp);

            StreamWriter outifle = new StreamWriter("pokemon.txt");
            for (int i = 0; i < count; i++)
            {
                outifle.WriteLine(pokemonToString(pokemons[i]));
            }
            outifle.Close();
        }
        private string pokemonToString(pokemon p)
        {
            string retVal = " ";
            retVal += p.name;
            retVal += "|";
            retVal += p.type.ToString();
            retVal += "|";
            retVal += p.level.ToString();
            retVal += "|";
            retVal += p.attacktype.ToString();
            retVal += "|";
            retVal += p.hp.ToString();
            retVal += p.xp.ToString();
            retVal += "|";
            retVal += p.legendary.ToString();
            retVal += "|";
            retVal += p.shiny.ToString();
            retVal += "|";
            retVal += p.generation.ToString();
            return retVal;
        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            save();
        }

        private void showpokemon(pokemon p)
        {
            nametextBox.Text = p.name;
            typetextBox.Text = p.type;
            levelnumericUpDown.Value = p.level;
            attackcomboBox.Text = p.attacktype.ToString();
            hpnumericUpDown.Value = p.hp;
            xpnumericUpDown.Value = p.xp;
            legendarycheckBox.Checked = p.legendary;
            shinycheckBox.Checked = p.shiny;
            generationnumericUpDown.Value = p.generation;   
        }

        private void firstbutton_Click(object sender, EventArgs e)
        {
            save();
            current = 0;
            currentlabel.Text = current.ToString();
            showpokemon(pokemons[current]);
        }

        private void lastbutton_Click(object sender, EventArgs e)
        {
            save();
            current = count -1;
            currentlabel.Text = current.ToString();
            showpokemon(pokemons[current]);
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            if (current > 0)
            {
                save();
                current -= 1;
                currentlabel.Text = current.ToString();
                showpokemon(pokemons[current]);
            }
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            if (current < count -1)
            {
                save();
                current++;
                currentlabel.Text = current.ToString();
                showpokemon(pokemons[current]);
            }
        }
        private void clear()
        {
            nametextBox.Text = " ";
            typetextBox.Text = " ";
            levelnumericUpDown.Value = 0;
            attackcomboBox.Text = " ";
            hpnumericUpDown.Value = 0;
            xpnumericUpDown.Value = 0;
            legendarycheckBox.Checked = false;
            shinycheckBox.Checked = false;
            generationnumericUpDown.Value = 0;
        }
        private void newbutton_Click(object sender, EventArgs e)
        {
            current = count;
            count++;
            clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            save();
        }
    }
}
