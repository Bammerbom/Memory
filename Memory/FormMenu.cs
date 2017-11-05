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
        private async void pictureBox1Speel_Click(object sender, EventArgs e)
        {
            this.pictureBox1Speel.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("SpeelButtonGroen2D");
            await Task.Delay(300);
            this.pictureBox1Speel.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("SpeelButtonGroen");
            FormStartgame startgame = new FormStartgame();
            startgame.ShowDialog();

        }

        /// <summary>
        /// sluit het programma af
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void pictureBox5Afsluiten_Click(object sender, EventArgs e)
        {
            this.pictureBox5Afsluiten.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("AfsluitenButtonRood2D");
            await Task.Delay(300);
            this.pictureBox5Afsluiten.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("AfsluitenButtonRood");
            this.Close();
           
        }

        /// <summary>
        /// opent de highscores form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void pictureBox3Highscores_Click(object sender, EventArgs e)
        {
            this.pictureBox3Highscores.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("HighscoresButtonBlauw2D");
            await Task.Delay(300);
            this.pictureBox3Highscores.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("HighscoresButtonBlauw");
            FormHighscores Highscores = new FormHighscores();
            Highscores.ShowDialog();

        }

        /// <summary>
        /// opened de help form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void pictureBox6Help_Click(object sender, EventArgs e)
        {
            this.pictureBox6Help.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("HelpButtonBlauw2D");
            await Task.Delay(300);
            this.pictureBox6Help.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("HelpButtonBlauw");
            FormHelp Help = new FormHelp();
            Help.ShowDialog();

        }

        /// <summary>
        /// opened de credits form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void pictureBox4Credits_Click(object sender, EventArgs e)
        {
            this.pictureBox4Credits.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("CreditsButtonBlauw2D");
            await Task.Delay(300);
            this.pictureBox4Credits.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("CreditsButtonBlauw");
            FormCredits Credits = new FormCredits();
            Credits.ShowDialog();
            
        }

        /// <summary>
        /// called de laadgame methode waarmee een spel word geladen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void pictureBox2Laden_Click(object sender, EventArgs e)
        {
            this.pictureBox2Laden.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("LadenButtonBlauw2D");
            await Task.Delay(300);
            this.pictureBox2Laden.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("LadenButtonBlauw");
            ManagerSavegames.Loadgame();

            
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
