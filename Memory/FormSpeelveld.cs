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
    public partial class FormSpeelveld : Form
    {
        /// <summary>
        /// load het dynamisch speelveld met de opgegeven grootte. afhankelijk van hoeveel kaarten moeten afgebeeld worden, worden de picture boxes groter gemaakt.
        /// ook de settings van de pictureboxes worden hier geset.
        /// </summary>
        public FormSpeelveld()
        {

            

            double yTussenruimte = 10;
            double xTussenruimte = 60;
            double xSizeTemp = 150;
            double ySizeTemp = 225;
            InitializeComponent();
            PictureBox[,] Kaart = new PictureBox[BaseGame.Width, BaseGame.Height];
            if (BaseGame.Width == 2 && BaseGame.Height == 2) //speelveld 2x2 vergroot de kaarten met factor 2
            {
                xSizeTemp *= 2;
                ySizeTemp *= 2;
            }
            else if (BaseGame.Width == 3 && BaseGame.Height == 2) //speelveld 2x3 vergroot de kaarten met 1.5
            {
                xSizeTemp *= 1.5;
                ySizeTemp *= 1.5;
            }
            else if (BaseGame.Width == 4 && BaseGame.Height == 2) //speelveld 2x4 vergroot de kaarten met 1.15
            {
                yTussenruimte = 10;
                xSizeTemp *= 1.15;
                ySizeTemp *= 1.15;
            }
            else if (BaseGame.Width == 4 && BaseGame.Height == 3) //speelveld 3x4 vergroot de kaarten met 1.15
            {
                yTussenruimte = 10;
                xSizeTemp *= 1.15;
                ySizeTemp *= 1.15;
            }
            else if (BaseGame.Width == 4 && BaseGame.Height == 4) //speelveld 4x4 geen vergroting
            {
                yTussenruimte = 10;
                xSizeTemp *= 1;
                ySizeTemp *= 1;
            }
            int yLocation = 25;
            for (int y = 0; y < BaseGame.Height; y++) //voert alle kaarten in met goede tussenruimtes en juiste locatie
            {
                int xLocation = 366; //begin locatie
                for (int x = 0; x < BaseGame.Width; x++)
                {
                    string Kaartnaam = "Kaart" + x + "" + y; //juiste naam geven
                    Kaart[x, y] = new PictureBox(); //maakt nieuwe picturebox
                    Kaart[x, y].Name = Kaartnaam;
                    Kaart[x, y].Size = new Size(Convert.ToInt32(xSizeTemp), Convert.ToInt32(ySizeTemp)); //juiste size per speelveld 
                    Kaart[x, y].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "Voorkant");
                    Kaart[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                    Kaart[x, y].BackColor = Color.Transparent;
                    Kaart[x, y].Visible = true;
                    Kaart[x, y].Anchor = AnchorStyles.Left;
                    Kaart[x, y].SizeMode = PictureBoxSizeMode.Zoom;
                    Kaart[x, y].Location = new Point(xLocation, yLocation); //nieuwe locatie
                    Kaart[x, y].BringToFront();
                    string eventnaam = Kaartnaam + "_Click";
                    int x2 = x;
                    int y2 = y;
                    Kaart[x, y].Click += new EventHandler((sender, e) => {
                        BaseGame.KaartKlik(x2, y2);
                    });
                    this.Controls.Add(Kaart[x, y]);
                    xLocation += Convert.ToInt32(xSizeTemp) + Convert.ToInt32(xTussenruimte); //nieuw x coördinaat
                }
                yLocation += Convert.ToInt32(ySizeTemp) + Convert.ToInt32(yTussenruimte); //nieuw y coördinaat
            }
            
        }

        /// <summary>
        /// called de exitgame methode waarbij de form word afgesloten en de endgame word geopend
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Exit_Click(object sender, EventArgs e) {
            BaseGame.Exitgame();
        }

        /// <summary>
        /// called de saveenend methode 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Opslaan_Click(object sender, EventArgs e) {
            ManagerSavegames.SaveEnEnd();
        }

        /// <summary>
        /// called de save en end methode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerSavegames.SaveEnEnd();
        }

        /// <summary>
        /// showed de help form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp Help = new FormHelp();
            Help.Show();
        }

        /// <summary>
        /// laat de credits form zien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCredits Credits = new FormCredits();
            Credits.Show();
        }

        /// <summary>
        /// called de exitgame methode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BaseGame.Exitgame();

        }

        /// <summary>
        /// called de savegame methode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerSavegames.Savegame();          
        }

        /// <summary>
        /// reset het spel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BaseGame.Gamemode == 2 && GameMultiplayerOnline.Reset()) return; 
            BaseGame.Reset();
            BaseGame.ResetVeld();
        }

        /// <summary>
        /// reset het spel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Buton_Reset_Click(object sender, EventArgs e)
        {
            if (BaseGame.Gamemode == 2 && GameMultiplayerOnline.Reset()) return;
            BaseGame.Reset();
            BaseGame.ResetVeld();
            
        }

        /// <summary>
        /// laad het thema voor het speelveld en de status van de mute button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSpeelveld_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "SpeelveldAchtergrond");

        }

        /// <summary>
        /// mute en unmute het geluid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Geluid.Volume == true)
            {
                Geluid.Volume = false;
                this.Volume.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("GeluidsicoontjeKruis");
                Geluid.Player.Stop();
            }
            else
            {
                Geluid.Volume = true;
                this.Volume.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("Geluidsicoontje");
            }

        }

        
        private void Textbox_Timer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
