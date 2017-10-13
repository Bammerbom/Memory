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
                GameSingleplayer.Start(BaseGame.Height, BaseGame.Width, BaseGame.Naam1);
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
            Application.Exit();
        }

        private void FormEndgame_Load(object sender, EventArgs e)
        {
           
            if (BaseGame.Gamemode == 0) //1 speler spel
            {
                LabelResultatenmatch.Text = "Gefeliciteerd! U heeft gewonnen.\nU heeft een score behaald van " + BaseGame.Score1 + " punten." 
                    + "\nU had " + BaseGame.Tijdtotaal + " seconden nodig om te winnen."
                    + "\nU had " + BaseGame.Zetten1 + " zetten nodig om te winnen." ;
            }
            else //2 speler spel
            {
                if (BaseGame.Score1 > BaseGame.Score2) //checkt of score van Player 1 groter is dan score van Player 2
                {
                    LabelResultatenmatch.Text = BaseGame.Naam1 + " heeft gewonnen met een score van: " + BaseGame.Score1 + " punten." 
                        + "\nMet een totale tijd van: " + BaseGame.Tijdtotaal + " seconden.\n" 
                        + BaseGame.Naam1 + " heeft " + BaseGame.Zetten1 + " zetten gebruikt."
                        + BaseGame.Naam2 + " heeft verloren met een score van: " + BaseGame.Score2 + "."; 
                }
                else if (BaseGame.Score1 < BaseGame.Score2) //checkt of score van P1 kleiner is dan score van P2
                {
                    LabelResultatenmatch.Text = BaseGame.Naam2 + " heeft gewonnen met een score van: " + BaseGame.Score2 + " punten." 
                        + "\nMet een totale tijd van: " + BaseGame.Tijdtotaal + " seconden.\n" 
                        + BaseGame.Naam2 + " heeft " + BaseGame.Zetten2 + " zetten gebruikt."
                        + BaseGame.Naam1 + " heeft verloren met een score van: " + BaseGame.Score1 + ".";
                }
                else if ((BaseGame.Score1 == BaseGame.Score2) && (BaseGame.Zetten1 > BaseGame.Zetten2)) //checkt of bij gelijk spel aantal zetten van P1 groter is dan aantal zetten van P2
                {
                    LabelResultatenmatch.Text = "Het is een gelijkspel!" + BaseGame.Naam1 + " heeft een score van: " + BaseGame.Score1 + " punten.\n" 
                        + BaseGame.Naam2 + " heeft een score van: " + BaseGame.Score2 + " punten.\n" 
                        + "De totale tijd is: " + BaseGame.Tijdtotaal + " seconden.\n"
                        + BaseGame.Naam1 + " heeft gewonnen. Je hebt de minste zetten gebruikt: " + BaseGame.Zetten1 + BaseGame.Naam2 
                        + " heeft " + BaseGame.Zetten2 + " gebruikt.";
                }
                else if ((BaseGame.Score1 == BaseGame.Score2) && (BaseGame.Zetten1 < BaseGame.Zetten2)) //checkt of bij gelijk spel aantal zetten van P1 kleiner is dan aantal zetten van P2
                {
                    LabelResultatenmatch.Text = "Het is een gelijkspel!" + BaseGame.Naam2 + " heeft een score van: " + BaseGame.Score2 + " punten.\n"
                        + BaseGame.Naam1 + " heeft een score van: " + BaseGame.Score1 + " punten.\n"
                        + "De totale tijd is: " + BaseGame.Tijdtotaal + " seconden.\n"
                        + BaseGame.Naam2 + " heeft gewonnen. Je hebt de minste zetten gebruikt: " + BaseGame.Zetten2 
                        + BaseGame.Naam1 + " heeft " + BaseGame.Zetten1 + " gebruikt.";
                }
            }
        }
    }
}
