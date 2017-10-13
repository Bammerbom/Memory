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
    public partial class FormEndgame : Form
    {
        public FormEndgame()
        {
            InitializeComponent();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            this.Close();
            BaseGame.Reset();
            if(BaseGame.Gamemode == 0) {
                GameSingleplayer.Start(BaseGame.Height, BaseGame.Width);
            }else if (BaseGame.Gamemode == 1) {
                GameMultiplayerLocal.Start(BaseGame.Height, BaseGame.Width);
            } else if(BaseGame.Gamemode == 2) {
                GameMultiplayerOnline.Start(BaseGame.Height, BaseGame.Width);
            }
        }

        private void ButtonStartgame_Click(object sender, EventArgs e)
        {
            this.Close();
            FormStartgame startgame = new FormStartgame();
            startgame.Show();
        }

        private void ButtonHighscored_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHighscores highscores = new FormHighscores();
            highscores.Show();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelGameResultaat()
        {
              
        }
        private void ButtonSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEndgame_Load(object sender, EventArgs e)
        {
           
            if (BaseGame.Gamemode == 0) //1 speler spel
            {
                LabelResultatenmatch.Text = "Gefeliciteerd! U heeft gewonnen.\nU heeft een score behaald van: " + BaseGame.Score1 + " met een tijd van: " + BaseGame.Tijdtotaal + "seconden.";
            }
            else
            {
                if (BaseGame.Score1 > BaseGame.Score2)
                {
                    LabelResultatenmatch.Text = BaseGame.Naam1 + " heeft gewonnen met een score van: " + BaseGame.Score1 + "met een tijd van: " + BaseGame.Tijdtotaal + " seconden."; //"Speler 1" veranderen in naam
                    LabelResultatenmatch2.Text = BaseGame.Naam2 + " heeft verloren met een score van: " + BaseGame.Score2 + ".";
                }
                else if (BaseGame.Score1 < BaseGame.Score2)
                {
                    LabelResultatenmatch.Text = BaseGame.Naam2 + " heeft gewonnen met een score van: " + BaseGame.Score2 + "met een tijd van: " + BaseGame.Tijdtotaal + " seconden.";
                    LabelResultatenmatch2.Text = BaseGame.Naam1 + " heeft verloren met een score van: " + BaseGame.Score1 + ".";
                }
                else
                {
                    LabelResultatenmatch.Text = "Het is een gelijkspel!" + BaseGame.Naam1 + " heeft een score van: " + BaseGame.Score1 + " en " + BaseGame.Naam2 + " heeft een score van: " + BaseGame.Score2;
                    LabelResultatenmatch2.Text = "De totale tijd is: " + BaseGame.Tijdtotaal;
                }
            }
        }
    }
}
