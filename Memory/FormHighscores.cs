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
        /// <summary>
        /// intialized de form
        /// </summary>
        public FormHighscores()
        {
            InitializeComponent();
        }

        private async void pictureBox1Terug_Click(object sender, EventArgs e)
        {
            this.pictureBox1Terug.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("TerugButtonBlauw2D");
            await Task.Delay(300);
            this.pictureBox1Terug.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("TerugButtonBlauw");
            this.Close();
            this.Dispose();
            GC.Collect();

        }
        /// <summary>
        /// laad de foto's voor de thema's en called de Load Tabellen methode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormHighscores_Load(object sender, EventArgs e)
        {

        this.pictureBox5.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "Picturebox1Highscore");
        this.pictureBox7.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "Picturebox2Highscore");

            //highscores table singelplayer
            //ManagerHighscores.CheckHighscoreFiles();
        Load_Tabbelen();
        }
        /// <summary>
        /// laad de highscore tabellen met highscores
        /// </summary>
        public void Load_Tabbelen()
        {
            dataGridViewSingelplayer.DataSource = ManagerHighscores.GetTable(false);
            dataGridViewSingelplayer.CurrentCell = null;
            dataGridViewSingelplayer.Columns[0].Width = 35;
            dataGridViewSingelplayer.Columns[1].Width = 260;
            dataGridViewSingelplayer.Columns[2].Width = 70;
            dataGridViewSingelplayer.Columns[3].Width = 70;
            //highscores table multiplayer
            dataGridViewMultiplayer.DataSource = ManagerHighscores.GetTable(true);
            dataGridViewMultiplayer.CurrentCell = null;
            dataGridViewMultiplayer.Columns[0].Width = 35;
            dataGridViewMultiplayer.Columns[1].Width = 260;
            dataGridViewMultiplayer.Columns[2].Width = 70;
            dataGridViewMultiplayer.Columns[3].Width = 70;
            for (int i = 1; i < 20; i+=2)
            {
                dataGridViewMultiplayer.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        /// <summary>
        /// vraagt of je zeker bent dat je de de singelplayer en/of multiplayer highscores gegefens wil verwijderen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Label_HighscoresVerwijderen_Click(object sender, EventArgs e)
        {
            this.HighscoresVerwijderen.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("HighscoresVerwijderenButtonRood2D");
            await Task.Delay(300);
            this.HighscoresVerwijderen.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("HighscoresVerwijderenButtonRood");

            DialogResult result1 = MessageBox.Show("Wil je de singleplayer highscores verwijderen?", "Verwijderen highscores singleplayer!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
