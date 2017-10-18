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
        

        //Maakt game klaar voor een nieuwe ronde
        public static void Reset() {           
            FormSpeelveld = null;
            Zetten1 = 0;
            Zetten2 = 0;
            Score1 = 0;
            Score2 = 0;
            Kaartcounter = 0;
            Tijdbeurt = 10;
            Tijdtotaal = 0;
            Terugdraai = false;
        }

        public static void InitSpeelveld(int h, int w) {
            //Initialize variabelen
            Height = h;
            Width = w;
            Speelveld_types = new int[w, h];
            Speelveld_omgedraaid = new bool[w, h];
            Tijdbeurt = 10;
            Tijdtotaal = 0;

            //Maak tijdelijke lijst met alle velden en shuffle die
            var tempvelden = new List<int>();
            int length = h * w / 2;
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

        public static void InitForm() {
            FormSpeelveld = new FormSpeelveld();
            FormSpeelveld.Show();




            ////Hide alle kaarten die buiten het speelveld liggen
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

        public static void KaartKlik(int x, int y, bool multi = true) { //multi wordt naar false gezet om een infinite loop te voorkomen
            if (Speelveld_omgedraaid[x, y] == true) return; //Negeer klikken op kaart als de kaart al omgedraait is
            if (Kaartcounter == 2) return; //Negeer als er al 2 kaarten omgedraait zijn

            if(Gamemode == 2 && multi) {
                if (GameMultiplayerOnline.KlikKaart(x, y)) return;
            }

            //Keer kaart om
            ZetOmgedraaid(x, y, true);

            Kaartcounter++;
            if (Kaartcounter == 1) {
                //Sla eerste kaart op
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
                    if (SpelerAanBeurt == 1) Score1++;  //Voeg 1 bij de score toe
                    if (SpelerAanBeurt == 2) Score2++;
                    Kaartcounter = 0;
                    Tijdbeurt = 10; //reset timer
                                        
                    if (Checkwin()) {    //Check voor win 
                        Endgame();
                    }
                } else {
                    DraaiKaartenTerug(); //Draai beide kaarten terug om
                }
                Render();
                if (multi) {
                    VolgendeBeurt();
                }
            }
        }

        public static async void DraaiKaartenTerug() {
            Terugdraai = true;
            Tijdbeurt = 10; // reset timer
            await Task.Delay(2000); 
            ZetOmgedraaid(Kaart1x, Kaart1y, false);
            ZetOmgedraaid(Kaart2x, Kaart2y, false);
            Kaartcounter = 0;            
            Terugdraai = false;
            Render();

            if (Gamemode == 2) {
                GameMultiplayerOnline.KlaarVoorVolgendeKlikkaart();
            }
        }

        public static void VolgendeBeurt() {
            if (Gamemode == 0) GameSingleplayer.VolgendeBeurt();
            else if (Gamemode == 1) GameMultiplayerLocal.VolgendeBeurt();
            else if (Gamemode == 2) GameMultiplayerOnline.VolgendeBeurt();
        }

        public static void Render() {
            FormSpeelveld.Textbox_Score_Speler_1.Text = Convert.ToString(Score1); //update textboxes
            FormSpeelveld.Textbox_Score_Speler_2.Text = Convert.ToString(Score2);
            FormSpeelveld.Textbox_Zetten_Speler_1.Text = Convert.ToString(Zetten1);
            FormSpeelveld.Textbox_Zetten_Speler_2.Text = Convert.ToString(Zetten2);
            if (SpelerAanBeurt == 1) {
                FormSpeelveld.TextBox_Beurt.Text = "Beurt:\n" + Naam1;
            } else {
                FormSpeelveld.TextBox_Beurt.Text = "Beurt:\n" + Naam2;
            }
        }

        public static async void Timer() {            
            while (Gamestate == 1)
            {

                while (Tijdbeurt > 0)  //loop die secondes telt
                {
                    await Task.Delay(1000);
                    if (Terugdraai == false)
                    {
                        Tijdbeurt--;
                    }
                    Tijdtotaal ++ ;
                    FormSpeelveld.Textbox_Timer.Text = Convert.ToString(Tijdbeurt);
                    if (Gamestate == 2)  // killed de timer als het spel is afgelopen.
                    {
                        return ;   
                    }
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

        //check of alle kaarten zijn omgedraaid en returned true als dat gebeurt is
        public static bool Checkwin() {
            foreach(bool omgedraaid in Speelveld_omgedraaid) {
                if (!omgedraaid) return false;
            }
            return true;
        }

        public static void Endgame() {
            if (Gamemode == 0) GameSingleplayer.End();
            else if (Gamemode == 1) GameMultiplayerLocal.End();
            else if (Gamemode == 2) GameMultiplayerOnline.End();
        }

        public static void ZetOmgedraaid(int x, int y, bool omgedraaid) {
            Speelveld_omgedraaid[x, y] = omgedraaid; //zet string in afkorting
            string kaartnaam = "Kaart" + x + "" + y; //zet kaartnaam in string voor gebruik in
            PictureBox box = ((PictureBox)FormSpeelveld.Controls[kaartnaam]);
            if (omgedraaid == true) {    //check of de kaart is omgedraaid
                int kaarttype = Speelveld_types[x, y];
                box.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Kaart" + kaarttype);  //verander plaatje kaart
                box.SizeMode = PictureBoxSizeMode.Zoom;
            } else {
                box.Image = Properties.Resources.KaartVoorkant;
                box.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
