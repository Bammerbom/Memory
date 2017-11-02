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
        /// <summary>
        /// initialized de form
        /// </summary>
        public FormEndgame()
        {
            InitializeComponent();
            FormEndgame.instance = this;
        }
        /// <summary>
        /// Restart het spel met dezelfde instellingen en namen als het vorig spel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Opened het de startgame form zodat je een nieuw spel kunt doen met andere instellingen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            startgame.ShowDialog();
        }
        /// <summary>
        /// opened de highscores form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonHighscored_Click(object sender, EventArgs e)
        {
            FormHighscores highscores = new FormHighscores();
            highscores.ShowDialog();
        }
        /// <summary>
        /// Closed de endgame form en reset de variabelen voor en nieuw spel gaat terug naar het hoofdmenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            GC.Collect();
            BaseGame.Reset();
        }


        /// <summary>
        /// sluit het complete programma af
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// zet bij het loaden van de form de scores in de labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
