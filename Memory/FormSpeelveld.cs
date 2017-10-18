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
            double yTussenruimte = -35;
            double xTussenruimte = 25;
            double xSizeTemp = 175;
            double ySizeTemp = 263;
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
                yTussenruimte = -18;
                xSizeTemp *= 1.15;
                ySizeTemp *= 1.15;
            }
            else if (BaseGame.Width == 4 && BaseGame.Height == 3) //speelveld 3x4 vergroot de kaarten met 1.15
            {
                yTussenruimte = -18;
                xSizeTemp *= 1.15;
                ySizeTemp *= 1.15;
            }
            else if (BaseGame.Width == 4 && BaseGame.Height == 4) //speelveld 4x4 geen vergroting
            {
                yTussenruimte = -18;
                xSizeTemp *= 1;
                ySizeTemp *= 1;
            }
            int yLocation = 5;
            for (int y = 0; y < BaseGame.Height; y++) //voert alle kaarten in met goede tussenruimtes en juiste locatie
            {
                int xLocation = 366; //begin locatie
                for (int x = 0; x < BaseGame.Width; x++)
                {
                    string Kaartnaam = "Kaart" + x + "" + y; //juiste naam geven
                    Kaart[x, y] = new PictureBox(); //maakt nieuwe picturebox
                    Kaart[x, y].Name = Kaartnaam;
                    Kaart[x, y].Size = new Size(Convert.ToInt32(xSizeTemp), Convert.ToInt32(ySizeTemp)); //juiste size per speelveld 
                    Kaart[x, y].Image = Properties.Resources.KaartVoorkant; 
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

        private void Button_Exit_Click(object sender, EventArgs e) {
            BaseGame.Endgame();
        }

        private void Button_Opslaan_Click(object sender, EventArgs e) {
            SaveGameManager.SaveEnEnd();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //TODO save
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
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO save
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            BaseGame.Reset();
            if (BaseGame.Gamemode == 0)
            {
                GameSingleplayer.Start(BaseGame.Height, BaseGame.Width, BaseGame.Naam1);
            }
            else if (BaseGame.Gamemode == 1)
            {
                GameMultiplayerLocal.Start(BaseGame.Height, BaseGame.Width,BaseGame.Naam1, BaseGame.Naam2);
            }
            else if (BaseGame.Gamemode == 2)
            {
                //TODO GameMultiplayerOnline.Start(BaseGame.Height, BaseGame.Width, );
            }
        }

        private void Buton_Reset_Click(object sender, EventArgs e)
        {
            this.Close();
            BaseGame.Reset();
            if (BaseGame.Gamemode == 0)
            {
                GameSingleplayer.Start(BaseGame.Height, BaseGame.Width, BaseGame.Naam1);
            }
            else if (BaseGame.Gamemode == 1)
            {
                GameMultiplayerLocal.Start(BaseGame.Height, BaseGame.Width, BaseGame.Naam1, BaseGame.Naam2);
            }
            else if (BaseGame.Gamemode == 2)
            {
                //TODO GameMultiplayerOnline.Start(BaseGame.Height, BaseGame.Width);
            }
        }

        private void FormSpeelveld_Load(object sender, EventArgs e)
        {

        }
    }
}
