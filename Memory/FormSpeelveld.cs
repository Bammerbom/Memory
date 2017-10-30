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
            if (Geluid.Volume == true)
            {
                this.Volume.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("Geluidsicoontje");
            }
            else
            {
                this.Volume.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("GeluidsicoontjeKruis");
            }
        }

        private void Button_Exit_Click(object sender, EventArgs e) {
            BaseGame.Exitgame();
        }

        private void Button_Opslaan_Click(object sender, EventArgs e) {
            ManagerSavegames.SaveEnEnd();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerSavegames.SaveEnEnd();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp Help = new FormHelp();
            Help.Show();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCredits Credits = new FormCredits();
            Credits.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BaseGame.Exitgame();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerSavegames.Savegame();          
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BaseGame.Gamemode == 2 && GameMultiplayerOnline.Reset()) return; 
            BaseGame.Reset();
            BaseGame.ResetVeld();
        }

        private void Buton_Reset_Click(object sender, EventArgs e)
        {
            BaseGame.Reset();
            BaseGame.ResetVeld();
        }


        private void FormSpeelveld_Load(object sender, EventArgs e)
        {        

            this.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "SpeelveldAchtergrond");
            if (ManagerThema.Themanummer == 1)
            {
                this.pictureBox1.BackColor = System.Drawing.Color.Navy; 
            }
            else if (ManagerThema.Themanummer == 2)
            {
                this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            }
            else
            {
                this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Geluid.Volume == true)
            {
                Geluid.Volume = false;
                this.Volume.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("GeluidsicoontjeKruis");
                Geluid.player.Stop();
            }
            else
            {
                Geluid.Volume = true;
                this.Volume.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("Geluidsicoontje");
            }
        }
    }
}
