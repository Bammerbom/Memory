using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class FormHighscores : Form
    {
        public FormHighscores()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHighscores_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                string path;
                if (i == 0)
                {
                    path = ManagerHighscores.path1;
                } else
                {
                    path = ManagerHighscores.path2;
                }
                int lineCount = File.ReadLines(path).Count();
                string text = "";
                if (lineCount != 0)
                {
                    string[] lines = File.ReadAllLines(path);
                    int nummer = 1;
                    foreach (string line in lines)
                    {
                        string[] inhoud = line.Split('|');
                        if (i == 0)
                        {
                            text += String.Format("{0}.  {1} {2} {3} {4}\n", nummer, inhoud[0], inhoud[1], inhoud[2], inhoud[3]);
                        } else
                        {
                            if (Convert.ToInt32(inhoud[1]) >= Convert.ToInt32(inhoud[5]))
                            {
                                text += string.Format("{0}. {1} {2} {3} {4}/n       {5} {6} {7}", nummer, inhoud[0], inhoud[1], inhoud[2], inhoud[3], inhoud[4], inhoud[5], inhoud[6]);
                            } else
                            {
                                text += string.Format("{0}. {5} {6} {7} {4}/n       {1} {2} {3}", nummer, inhoud[0], inhoud[1], inhoud[2], inhoud[3], inhoud[4], inhoud[5], inhoud[6]);
                            }
                        }
                        nummer++;
                    }
                } else
                {
                    text = "Geen Resultaten";
                }
                if (i == 0)
                {
                    Highscores_1spelers.Text = text;
                } else
                {
                    Highscores_2spelers.Text = text;
                }
            }
        }
    }
}
