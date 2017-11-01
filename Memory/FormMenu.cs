using System;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void pictureBox1Speel_Click(object sender, EventArgs e)
        {
            {
                FormStartgame startgame = new FormStartgame();
                startgame.ShowDialog();
            }
        }
        private void pictureBox5Afsluiten_Click(object sender, EventArgs e)
        {
        this.Close();
           
        }
        private void pictureBox3Highscores_Click(object sender, EventArgs e)
        {
            {
                FormHighscores Highscores = new FormHighscores();
                Highscores.ShowDialog();
            }
        }

        private void pictureBox6Help_Click(object sender, EventArgs e)
        {
            {
                FormHelp Help = new FormHelp();
                Help.ShowDialog();
            }
        }
        private void pictureBox4Credits_Click(object sender, EventArgs e)
        {
            {
                FormCredits Credits = new FormCredits();
                Credits.ShowDialog();
            }
        }


        private void pictureBox2Laden_Click(object sender, EventArgs e)
        {
            {
                ManagerSavegames.Loadgame();

            }
        }

        private void ThemaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerThema.VeranderThema(ThemaBox.Text);

            this.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "MenuAchtergrond");
            Geluid.Player.Dispose();
            Geluid.str.Dispose();
            GC.Collect();                
            Geluid.AchtergrondMuziek();

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Geluid.Volume = true;
            this.Volume.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("Geluidsicoontje");
            ManagerThema.Themaprefix = "Thema0";
            ManagerThema.Themanummer = 0;
            this.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "MenuAchtergrond");
            Geluid.AchtergrondMuziek();
        }

        private void Volume_Click(object sender, EventArgs e)
        {
            if (Geluid.Volume == true)
            {
                Geluid.Volume = false;
                this.Volume.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("GeluidsicoontjeKruis");
                Geluid.Player.Stop();
                Geluid.Player.Dispose();
            }
            else
            {
                Geluid.Volume = true;
                this.Volume.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("Geluidsicoontje");
                Geluid.AchtergrondMuziek();
            }
        }
    }
}
