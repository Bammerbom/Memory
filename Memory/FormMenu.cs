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
    
        /// <summary>
        /// intialize form
        /// </summary>
        public FormMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  opened de startgame form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1Speel_Click(object sender, EventArgs e)
        {
            {
                FormStartgame startgame = new FormStartgame();
                startgame.ShowDialog();
            }
        }

        /// <summary>
        /// sluit het programma af
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox5Afsluiten_Click(object sender, EventArgs e)
        {
        this.Close();
           
        }

        /// <summary>
        /// opent de highscores form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3Highscores_Click(object sender, EventArgs e)
        {
            {
                FormHighscores Highscores = new FormHighscores();
                Highscores.ShowDialog();
            }
        }

        /// <summary>
        /// opened de help form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox6Help_Click(object sender, EventArgs e)
        {
            {
                FormHelp Help = new FormHelp();
                Help.ShowDialog();
            }
        }

        /// <summary>
        /// opened de credits form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox4Credits_Click(object sender, EventArgs e)
        {
            {
                FormCredits Credits = new FormCredits();
                Credits.ShowDialog();
            }
        }

        /// <summary>
        /// called de laadgame methode waarmee een spel word geladen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2Laden_Click(object sender, EventArgs e)
        {
            {
                ManagerSavegames.Loadgame();

            }
        }

        /// <summary>
        /// veranderd de muziek het achtergrond wanneer de combobox word verandert.
        /// ook word hier een variabele geupdtate die gebruikt word om de theam's te laden in andere forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThemaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerThema.VeranderThema(ThemaBox.Text);

            this.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "MenuAchtergrond");
            Geluid.Player.Dispose();
            Geluid.str.Dispose();
            GC.Collect();                
            Geluid.AchtergrondMuziek();

        }

        /// <summary>
        /// laad het standaard thema bij opstarten van het programma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMenu_Load(object sender, EventArgs e)
        {
            Geluid.Volume = true;
            this.Volume.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("Geluidsicoontje");
            ManagerThema.Themaprefix = "Thema0";
            ManagerThema.Themanummer = 0;
            this.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "MenuAchtergrond");
            Geluid.AchtergrondMuziek();
        }

        /// <summary>
        /// mute & unmute het geluid. set ook een variabele die word gebruikt bij het loaden van aaandere froms om te bepalen of het geluid uit of aan moet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
