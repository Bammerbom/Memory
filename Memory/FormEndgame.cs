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
        public static FormEndgame instance;
        public FormEndgame()
        {
            InitializeComponent();
            FormEndgame.instance = this;
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            if (BaseGame.Gamemode == 2 && GameMultiplayerOnline.Reset()) return;
            this.Close();
            this.Dispose();
            GC.Collect();
            BaseGame.Reset();
            if(BaseGame.Gamemode == 0) {
                GameSingleplayer.Start(BaseGame.Height, BaseGame.Width, BaseGame.Naam1);
            }else if (BaseGame.Gamemode == 1) {
                GameMultiplayerLocal.Start(BaseGame.Height, BaseGame.Width, BaseGame.Naam1, BaseGame.Naam2);
            }else if(BaseGame.Gamemode == 2) {
                GameMultiplayerOnline.Reset2();
            }
        }

        private void ButtonStartgame_Click(object sender, EventArgs e)
        {
            if (BaseGame.Gamemode == 2) {
                GameMultiplayerOnline.Disconnect();
            }
            this.Close();
            this.Dispose();
            GC.Collect();
            BaseGame.Reset();
            FormStartgame startgame = new FormStartgame();
            startgame.Show();
        }

        private void ButtonHighscored_Click(object sender, EventArgs e)
        {
            FormHighscores highscores = new FormHighscores();
            highscores.Show();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            GC.Collect();
            BaseGame.Reset();
        }

        private void LabelGameResultaat()               //<----------------------- ?
        {
              
        }
        private void ButtonSluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormEndgame_Load(object sender, EventArgs e)
        {
            Geluid.AchtergrondMuziek();
            if (BaseGame.Gamemode == 0 && BaseGame.Checkwin() == true) //1 speler spel
            {
                LabelResultatenmatch.Text = "Gefeliciteerd! U heeft gewonnen.\nU heeft een score behaald van " + BaseGame.Score1 + " punten." 
                    + "\nU had " + BaseGame.Tijdtotaal + " seconden nodig om te winnen."
                    + "\nU had " + BaseGame.Zetten1 + " zetten nodig om te winnen." ;
            }
            else if (BaseGame.Checkwin() == true) //2 speler spel
            {
                String winnaam = BaseGame.Score1 > BaseGame.Score2 ? BaseGame.Naam1 : BaseGame.Naam2;
                String verliesnaam = BaseGame.Score1 < BaseGame.Score2 ? BaseGame.Naam1 : BaseGame.Naam2;
                if(BaseGame.Score1 != BaseGame.Score2) {
                    //Er is een winnaar
                    LabelResultatenmatch.Text = winnaam + " heeft gewonnen!\n"
                        + BaseGame.Naam1 + " heeft score: " + BaseGame.Score1 + " (Zetten: " + BaseGame.Zetten1 + ")\n"
                        + BaseGame.Naam2 + " heeft score: " + BaseGame.Score2 + " (Zetten: " + BaseGame.Zetten2 + ")";
                } else {
                    //Is aantal zetten gelijk?
                    if(BaseGame.Zetten1 != BaseGame.Zetten2) {
                        winnaam = BaseGame.Zetten1 < BaseGame.Zetten2 ? BaseGame.Naam1 : BaseGame.Naam2;
                        verliesnaam = BaseGame.Zetten1 > BaseGame.Zetten2 ? BaseGame.Naam1 : BaseGame.Naam2;
                        LabelResultatenmatch.Text = winnaam + " heeft gewonnenen met minder zetten!\n"
                        + BaseGame.Naam1 + " heeft score: " + BaseGame.Score1 + " (Zetten: " + BaseGame.Zetten1 + ")\n"
                        + BaseGame.Naam2 + " heeft score: " + BaseGame.Score2 + " (Zetten: " + BaseGame.Zetten2 + ")";
                    } else {
                        LabelResultatenmatch.Text = "Gelijkspel! Beide spelers hebben evenveel score en zetten.\n"
                        + BaseGame.Naam1 + " heeft score: " + BaseGame.Score1 + " (Zetten: " + BaseGame.Zetten1 + ")\n"
                        + BaseGame.Naam2 + " heeft score: " + BaseGame.Score2 + " (Zetten: " + BaseGame.Zetten2 + ")";
                    }
                }
            }
            else
            {
                LabelResultatenmatch.Text = "het spel is voortijdig beëindigt.";
            }
        }
    }
}
