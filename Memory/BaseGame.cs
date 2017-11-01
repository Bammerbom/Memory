using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Memory
{
    class BaseGame
    {
        public static FormSpeelveld FormSpeelveld;
        public static int Gamemode; // 0 = Singleplayer, 1 = Local, 2 = Online
        public static int Gamestate = 0; // 0 = Niet gestart, 1 = Ingame, 2 = Geeindigt
        public static int[,] Speelveld_types;  //deze array bevat de identiteit van de kaarten
        public static bool[,] Speelveld_omgedraaid;    //deze array bevat de status van de kaarten
        public static int Height;  //hoogte speelveld
        public static int Width;  //breedte speelveld
        public static int Zetten1 = 0;  //aantal zetten van de spelers
        public static int Zetten2 = 0;
        public static int Score1 = 0;  // aantal punten van spelers
        public static int Score2 = 0;
        public static int Kaart1x;  //coördinaten van de getrokken kaarten
        public static int Kaart1y;
        public static int Kaart2x;
        public static int Kaart2y;
        public static int Kaartcounter = 0;   // aantal getrokken kaarten in 1 beurt
        public static string Naam1;    // namen spelers
        public static string Naam2;
        public static int SpelerAanBeurt; // 1 = Speler 1, 2 = Speler 2
        public static int Tijdbeurt;  //de tijd counter voor de tijd die je hebt in een beurt
        public static int Tijdtotaal;  //de totale tijd die het spel in beslag neemt
        public static bool Terugdraai;  // false = er worden geen kaarten terug gedraaid , true = er worden kaarten teruggedraaid

        /// <summary>
        /// Alle score gerelateerde variabelen worden hier leeggemaakt voor een nieuw spel.
        /// </summary>
        public static void Reset() {
            Zetten1 = 0;
            Zetten2 = 0;
            Score1 = 0;
            Score2 = 0;
            Kaartcounter = 0;
            Tijdbeurt = 10;
            Tijdtotaal = 0;
            Terugdraai = false;
        }
        /// <summary>
        /// Deze methode word samen met de Reset methode gecalled om het veld te resetten.
        /// In deze methode worden de kaarten opnieuw gehusseld en teruggedraaid.
        /// Vervolgen word de Render methode gecalled.
        /// </summary>
        public static void ResetVeld() // reset het veld midgame met variabelen van standaard Reset
        {
           
            InitSpeelveld(Height, Width); //reset kaarten variabelen

            //reset alle kaarten onscreen
            for (int h = 0; h < BaseGame.Height; h++)
            {
                for (int w = 0; w < BaseGame.Width; w++)
                {
                    BaseGame.ZetOmgedraaid(w, h, BaseGame.Speelveld_omgedraaid[w, h]);
                }
            }

            Render();

        }
        /// <summary>
        /// Hier worden de Hoogte en Breedte van het veld in de betreffende variabelen gezet
        /// en worden de 2 2D arrays geinit die alle benodigde data van het veld bevatten.
        /// vervolgens worden alle kaartid's in een list geplaatst welke geshufled word en vervolgens in de 2D array word geplaatst.
        /// </summary>
        /// <param name="Hoogte"> ingevoerde hoogte van het speelveld</param>
        /// <param name="Breedte"> ingevooerde breedte van het speelveld</param>
        public static void InitSpeelveld(int Hoogte, int Breedte) {
            //Initialize variabelen
            Height = Hoogte;
            Width = Breedte;
            Speelveld_types = new int[Breedte, Hoogte];
            Speelveld_omgedraaid = new bool[Breedte, Hoogte];
            Tijdbeurt = 10;
            Tijdtotaal = 0;
            

            //Maak tijdelijke lijst met alle velden en shuffle die
            var tempvelden = new List<int>();
            int length = Hoogte * Breedte / 2;
            for (int i = 0; i < length; i++) {
                tempvelden.Add(i);
                tempvelden.Add(i);
            }
            tempvelden = Utils.ShuffleList(tempvelden);

            //Voer alle velden in in de 2d array
            for (int y = 0; y < Height; y++) {
                for (int x = 0; x < Width; x++) {
                    int pos = y * Width + x;
                    Speelveld_types[x,y] = tempvelden[pos];
                    Speelveld_omgedraaid[x,y] = false;
                }
            }
        }
        /// <summary>
        /// Hier word het speelveld form gemaakt en geopend
        /// </summary>
        public static void InitForm() {
            FormSpeelveld = new FormSpeelveld();
            FormSpeelveld.Show();

            ///Hide alle kaarten die buiten het speelveld liggen
            //for (int y = 3; y >= Height; y--)
            //{
            //    for (int x = 0; x < 4; x++)
            //    {
            //        PictureBox box = ((PictureBox)FormSpeelveld.Controls["Kaart" + x + "" + y]);
            //        box.Visible = false;
            //    }
            //}
            //for (int x = 3; x >= Width; x--)
            //{
            //    for (int y = 0; y < 4; y++)
            //    {
            //        PictureBox box = ((PictureBox)FormSpeelveld.Controls["Kaart" + x + "" + y]);
            //        box.Visible = false;
            //    }
            //}

            //Render standaard waardes
            Render();
        }
        /// <summary>
        /// Deze methode word gecalled wanneer er een kaart op het speelveld word aangeklikt.
        /// Eerst word gechecked of de aangeklikte kaart al is omgedraaid of dat er al 2 kaarten zijn omgedraaid deze beurt, als dit zo is dan word de methode stopgezet.
        /// vervolgens word de kaart omgedraaid en word de counter die bijhoud hoeveel kaarten zijn omgedraaid deze beurt verhoogd.
        /// Als dit de tweede kaart is die word aangeklikt dan word gechecked of ze gelijk zijn. zo ja dan word de score van de speler die aan beurt is verhoogd, zo niet dan word de methode zetomgedraaid gecalled om ze weer terug te draaien.
        /// ook word dan gecheckt of dit het laatst omgedraaide paar is. zo ja dan word de endgame methode gecalled.
        /// vervolgens word de beurt aaan de andere speler gegeven mits er een multiplayer spel word gespeeld
        /// </summary>
        /// <param name="x"> x coordinaat van aangeklikte coordinaat</param>
        /// <param name="y"> y coordinaat van aangeklikte kaart</param>
        /// <param name="Negeerkaartklik"> word op false gezet wanner de ander speler aan de beurt is in een online multiplayer spel. voorkomt dat de speler die niet aan beurt is kaarten kan omdraaien.</param>
        public static void KaartKlik(int x, int y, bool Negeerkaartklik = true) { //word op false gezet als andere speler aan beurt in is GameMultiplayerOnline spel
            if (Speelveld_omgedraaid[x, y] == true) return; //Negeer klikken op kaart als de kaart al omgedraait is
            if (Kaartcounter == 2) return; //Negeer als er al 2 kaarten omgedraait zijn

            if(Gamemode == 2 && Negeerkaartklik) {
                if (GameMultiplayerOnline.KlikKaart(x, y)) return;
            }

            //Keer kaart om
            ZetOmgedraaid(x, y, true);


            Kaartcounter++;
            if (Kaartcounter == 1) {
                //Sla eerste kaart op
                Geluid.KaartKlik();
                Kaart1x = x;
                Kaart1y = y;
            } else if (Kaartcounter == 2) {
                //Verhoog aantal zetten
                if (SpelerAanBeurt == 1) Zetten1++;
                if (SpelerAanBeurt == 2) Zetten2++;

                //Sla tweede kaart op
                Kaart2x = x;
                Kaart2y = y;

                //Kijk of kaarten gelijk zijn
                if (Speelveld_types[Kaart1x, Kaart1y] == Speelveld_types[Kaart2x, Kaart2y]) {
                    Geluid.KaartGelijk();
                    if (SpelerAanBeurt == 1) Score1++;  //Voeg 1 bij de score toe
                    if (SpelerAanBeurt == 2) Score2++;
                    Kaartcounter = 0;
                    Tijdbeurt = 10; //reset timer
                                        
                    if (Checkwin()) {    //Check voor win 
                        Endgame();
                        return;
                    }
                } else {
                    Geluid.KaartKlik();
                    DraaiKaartenTerug(); //Draai beide kaarten terug om
                }
                Render();
                if (Negeerkaartklik) {
                    VolgendeBeurt();
                }
            }
        }
        /// <summary>
        /// Deze methode draait kaarten terug wanneer er een verkeerd paar is omgedraaid met een delay van 2 seconden.
        /// </summary>
        public static async void DraaiKaartenTerug() {
            Terugdraai = true;
            Tijdbeurt = 10; // reset timer
            await Task.Delay(2000);
            try {
                ZetOmgedraaid(Kaart1x, Kaart1y, false);
                ZetOmgedraaid(Kaart2x, Kaart2y, false);
                Kaartcounter = 0;
                Terugdraai = false;
                Render();

                if (Gamemode == 2) {
                    GameMultiplayerOnline.KlaarVoorVolgendeKlikkaart();
                }
            } catch { };
        }

        /// <summary>
        /// Deze methode wisslet de speler die ann beurt is wanneer hij word gecalled.
        /// </summary>
        public static void VolgendeBeurt() {
            if (Gamemode == 0) GameSingleplayer.VolgendeBeurt();
            else if (Gamemode == 1) GameMultiplayerLocal.VolgendeBeurt();
            else if (Gamemode == 2) GameMultiplayerOnline.VolgendeBeurt();
        }

        /// <summary>
        /// deze methode update de textboxes in het score bord van het speelveld.
        /// </summary>
        public static void Render() {
            FormSpeelveld.Textbox_Score_Speler_1.Text = Convert.ToString(Score1); //update textboxes
            FormSpeelveld.Textbox_Score_Speler_2.Text = Convert.ToString(Score2);
            FormSpeelveld.Textbox_Zetten_Speler_1.Text = Convert.ToString(Zetten1);
            FormSpeelveld.Textbox_Zetten_Speler_2.Text = Convert.ToString(Zetten2);
            FormSpeelveld.Textbox_Timer.Text = Convert.ToString(Tijdbeurt);
            if (SpelerAanBeurt == 1) {
                FormSpeelveld.TextBox_Beurt.Text = "Beurt:\n" + Naam1;
            } else {
                FormSpeelveld.TextBox_Beurt.Text = "Beurt:\n" + Naam2;
            }
        }

        /// <summary>
        /// Dit is de timer die langzaam afteld en een beurt afpakt wanneer dde timer afloopt.
        /// </summary>
        public static async void Timer() {            //timer methode 
            while (Gamestate == 1)
            {

                while (Tijdbeurt > 0)  //loop die secondes telt
                {
                    if (Gamestate == 2)  // killed de timer als het spel is afgelopen.
                    {
                        return;
                    }
                    await Task.Delay(1000);
                    if (Terugdraai == false)
                    {
                        Tijdbeurt--;
                    }
                    Tijdtotaal ++ ;
                    FormSpeelveld.Textbox_Timer.Text = Convert.ToString(Tijdbeurt);

                }

                Tijdbeurt = 10; //timer reset

                if (SpelerAanBeurt == 1)
                {
                    Zetten1++;
                    FormSpeelveld.Textbox_Zetten_Speler_1.Text = Convert.ToString(Zetten1);
                }
                if (SpelerAanBeurt == 2)
                {
                    Zetten2++;
                    FormSpeelveld.Textbox_Zetten_Speler_1.Text = Convert.ToString(Zetten2);
                }
                

            }

            
        }

        /// <summary>
        /// Deze methode checked of alle kaarten zijn omgedraait
        /// </summary>
        /// <returns>returns true wanneer alle kaarten zijn omgedraaid</returns>
        public static bool Checkwin() {
            foreach(bool omgedraaid in Speelveld_omgedraaid) {
                if (!omgedraaid) return false;
            }
            return true;
        }
        /// <summary>
        /// redirect naar de end game van de betreffende gamemode en slaat highscores op.
        /// </summary>
        public static void Endgame() {
            Geluid.GameOver();
            BaseGame.GameResultatenOpslaan();
            if (Gamemode == 0) GameSingleplayer.End();
            else if (Gamemode == 1) GameMultiplayerLocal.End();
            else if (Gamemode == 2) GameMultiplayerOnline.End();
        }
        /// <summary>
        /// redirect naar de exit game methode van de betreffende gamemode.
        /// </summary>
        public static void Exitgame()
        {
            Geluid.GameOver();
            if (Gamemode == 0) GameSingleplayer.Exit();
            else if (Gamemode == 1) GameMultiplayerLocal.Exit();
            else if (Gamemode == 2) GameMultiplayerOnline.Exit();
        }
        /// <summary>
        /// Draait een kaart om door het plaatje in een picturebox te veranderen.
        /// </summary>
        /// <param name="x">X coordinaat van kaart</param>
        /// <param name="y">Y coordinaat van kaart</param>
        /// <param name="omgedraaid"> variabele die aangeeft of een kaart omgedraaid is of niet.</param>
        public static void ZetOmgedraaid(int x, int y, bool omgedraaid) {
            Speelveld_omgedraaid[x, y] = omgedraaid; //zet string in afkorting
            string kaartnaam = "Kaart" + x + "" + y; //zet kaartnaam in string voor gebruik in
            PictureBox box = ((PictureBox)FormSpeelveld.Controls[kaartnaam]);
            if (omgedraaid == true) {    //check of de kaart is omgedraaid
                try
                {
                    int kaarttype = Speelveld_types[x, y];
                    box.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "Kaart" + kaarttype);  //verander plaatje kaart
                    box.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch
                {
                    Console.WriteLine("picture_error");
                }
            } else {
                try
                {
                    box.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "Voorkant");
                    box.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch
                {
                    Console.WriteLine("picture_error");
                }
            }
        }

        /// <summary>
        /// slaat de scores van het spel op in de highscores
        /// </summary>
        public static void GameResultatenOpslaan()
        {
            ManagerHighscores.CheckHighscoreFiles();
            if (Gamemode == 0)
            {
                ManagerHighscores.SingleplayerSave();
            }
            else if (Gamemode == 1 || Gamemode == 2)
            {
                ManagerHighscores.MultiplayerLocalSave();
            }
        }
    }
}
