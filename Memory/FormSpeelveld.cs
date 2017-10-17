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
            InitializeComponent();
        }

        private void Kaart0_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(0,0);
        }

        private void Kaart1_Click(object sender, EventArgs e)
        {

            BaseGame.KaartKlik(1,0);
        }

        private void Kaart2_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(2,0);
        }

        private void Kaart3_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(3,0);
        }

        private void Kaart4_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(0,1);
        }

        private void Kaart5_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(1,1);
        }

        private void Kaart6_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(2,1);
        }

        private void Kaart7_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(3,1);
        }

        private void Kaart8_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(0,2);
        }

        private void Kaart9_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(1,2);
        }

        private void Kaart10_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(2,2);
        }

        private void Kaart11_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(3,2);
        }

        private void Kaart12_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(0,3);
        }

        private void Kaart13_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(1,3);
        }

        private void Kaart14_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(2,3);
        }

        private void Kaart15_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(3,3);
        }

        private void Button_Exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Button_Opslaan_Click(object sender, EventArgs e) {
            this.Close();
            //TODO save
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
                GameMultiplayerLocal.Start(BaseGame.Height, BaseGame.Width);
            }
            else if (BaseGame.Gamemode == 2)
            {
                GameMultiplayerOnline.Start(BaseGame.Height, BaseGame.Width);
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
                GameMultiplayerLocal.Start(BaseGame.Height, BaseGame.Width);
            }
            else if (BaseGame.Gamemode == 2)
            {
                GameMultiplayerOnline.Start(BaseGame.Height, BaseGame.Width);
            }
        }

        private void FormSpeelveld_Load(object sender, EventArgs e)
        {

        }
    }
}
