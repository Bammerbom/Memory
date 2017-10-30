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
                startgame.Show();
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
                Highscores.Show();
            }
        }

        private void pictureBox6Help_Click(object sender, EventArgs e)
        {
            {
                FormHelp Help = new FormHelp();
                Help.Show();
            }
        }
        private void pictureBox4Credits_Click(object sender, EventArgs e)
        {
            {
                FormCredits Credits = new FormCredits();
                Credits.Show();
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
            ThemaManager.VeranderThema(ThemaBox.Text);
            this.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(ThemaManager.Themaprefix + "MenuAchtergrond");

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            ThemaManager.Themaprefix = "Thema0";
            ThemaManager.Themanummer = 0;
            this.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(ThemaManager.Themaprefix + "MenuAchtergrond");
        }

        
    }
}
