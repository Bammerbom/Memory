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

        private void FormHighscores_Load(object sender, EventArgs e)
        {
            ManagerHighscores.CheckHighscoreFiles();
            Load_Tabbelen();
        }

        public void Load_Tabbelen()
        {
            dataGridViewSingelplayer.DataSource = ManagerHighscores.GetTableSingelplayer();
            dataGridViewMultiplayer.DataSource = ManagerHighscores.GetTableMultiplayer();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label_HighscoresVerwijderen_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Wil je de singelplayer highscores verwijderen?", "Verwijderen highscores singelplayer!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result1 != DialogResult.Cancel)
            {
                DialogResult result2 = MessageBox.Show("Wil je de multiplayer highscores verwijderen?", "Verwijderen highscores multiplayer!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result2 != DialogResult.Cancel)
                {
                    if (result1 == DialogResult.Yes)
                    {
                        File.Create(ManagerHighscores.path1).Close();
                    }
                    if (result2 == DialogResult.Yes)
                    {
                        File.Create(ManagerHighscores.path2).Close();
                    }
                    Load_Tabbelen();
                }
            }
        }
    }
}






//oud: lines file naar text label

//for (int i = 0; i < 2; i++)
//{
//    string path;
//    if (i == 0)
//    {
//        path = ManagerHighscores.path1;
//    } else
//    {
//        path = ManagerHighscores.path2;
//    }
//    int lineCount = File.ReadLines(path).Count();
//    string text = "";
//    if (lineCount != 0)
//    {
//        string[] lines = File.ReadAllLines(path);
//        int nummer = 1;
//        text += "      naam       score   zetten tijd\n";
//        foreach (string line in lines)
//        {
//            string[] inhoud = line.Split('|');
//            if (i == 0)
//            {
//                text += string.Format("{0,-4}  {1,-20} {2,-7} {3,-6} {4,-5}\n", nummer + ".", inhoud[0], inhoud[1], inhoud[2], inhoud[3]);
//            } else
//            {
//                if (Convert.ToInt32(inhoud[1]) >= Convert.ToInt32(inhoud[5]))
//                {
//                    text += string.Format("{0,-4}  {1,-10} {2,-7} {3,-6} {4,-5}\n     {5} {6} {7}\n", nummer, inhoud[0], inhoud[1], inhoud[2], inhoud[3], inhoud[4], inhoud[5], inhoud[6]);
//                } else
//                {
//                    text += string.Format("{0,-4}  {5,-10} {6,-7} {7,-6} {4,-5}\n     {1,-10} {2,-5} {3-4}\n", nummer, inhoud[0], inhoud[1], inhoud[2], inhoud[3], inhoud[4], inhoud[5], inhoud[6]);
//                }
//            }
//            nummer++;
//        }
//    } else
//    {
//        text = "Geen Resultaten";
//    }
//    if (i == 0)
//    {
//        Highscores_1spelers.Text = text;
//    } else
//    {
//        Highscores_2spelers.Text = text;
//    }
