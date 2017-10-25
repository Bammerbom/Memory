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
        this.pictureBox5.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(ThemaManager.Themaprefix + "Picturebox1Highscore");
        this.pictureBox7.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(ThemaManager.Themaprefix + "Picturebox2Highscore");

            //highscores table singelplayer
            ManagerHighscores.CheckHighscoreFiles();
        Load_Tabbelen();
        }

        public void Load_Tabbelen()
        {
            dataGridViewSingelplayer.DataSource = ManagerHighscores.GetTableSingelplayer();
            dataGridViewSingelplayer.CurrentCell = null;
            dataGridViewSingelplayer.Columns[0].Width = 35;
            dataGridViewSingelplayer.Columns[1].Width = 260;
            dataGridViewSingelplayer.Columns[2].Width = 70;
            dataGridViewSingelplayer.Columns[3].Width = 70;
            //highscores table multiplayer
            dataGridViewMultiplayer.DataSource = ManagerHighscores.GetTableMultiplayer();
            dataGridViewMultiplayer.CurrentCell = null;
            dataGridViewMultiplayer.Columns[0].Width = 35;
            dataGridViewMultiplayer.Columns[1].Width = 260;
            dataGridViewMultiplayer.Columns[2].Width = 70;
            dataGridViewMultiplayer.Columns[3].Width = 70;         
        }

        //vraagt of je zeker bent dat je de de singelplayer en/of multiplayer highscores gegefens wil verwijderen
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
                    //reload de tabellen zodat ze leeg zijn
                    Load_Tabbelen();
                }
            }
        }
    }
}
