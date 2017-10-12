using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    class BaseGame
    {
        public static FormSpeelveld FormSpeelveld;
        public static int Gamemode; // 0 = Singleplayer, 1 = Local, 2 = Online
        public static int[,] Speelveld_types;
        public static bool[,] Speelveld_omgedraaid;
        public static int Height;
        public static int Width;
        public static int Zetten1 = 0;
        public static int Zetten2 = 0;
        public static int Kaart; // Waar is dit voor?
        public static int Score1 = 0;
        public static int Score2 = 0;
        public static int Kaart1x;
        public static int Kaart1y;
        public static int Kaart2x;
        public static int Kaart2y;
        public static int Kaartcounter = 0;
        public static string Naam1;
        public static string Naam2;
        public static int SpelerAanBeurt; // 1 = Speler 1, 2 = Speler 2
        public static int Tijdbeurt;
        public static int Tijdtotaal;

        public static void InitSpeelveld(int h, int w) {
            //Initialize variabelen
            Height = h;
            Width = w;
            Speelveld_types = new int[h, w];
            Speelveld_omgedraaid = new bool[h, w];
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
                    Speelveld_types[x, y] = tempvelden[pos];
                    Speelveld_omgedraaid[x, y] = false;
                }
            }
        }

        public static void InitForm() {
            FormSpeelveld = new FormSpeelveld();
            FormSpeelveld.Show();

            //Hide alle kaarten die buiten het speelveld liggen
            for (int y = 3; y >= Height; y--) {
                for (int x = 0; x < 4; x++) {
                    PictureBox box = ((PictureBox)FormSpeelveld.Controls["Kaart" + x + "" + y]);
                    box.Visible = false;
                }
            }
            for (int x = 3; x >= Width; x--) {
                for (int y = 0; y < 4; y++) {
                    PictureBox box = ((PictureBox)FormSpeelveld.Controls["Kaart" + x + "" + y]);
                    box.Visible = false;
                }
            }

            //Render standaard waardes
            Render();
        }

        public static void KaartKlik(int x, int y) {
            if (Speelveld_omgedraaid[x, y] == true) return; //Negeer klikken op kaart als de kaart al omgedraait is
            if (Kaartcounter == 2) return; //Negeer als er al 2 kaarten omgedraait zijn

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
                    //Voeg 1 bij de score toe
                    if (SpelerAanBeurt == 1) Score1++;
                    if (SpelerAanBeurt == 2) Score2++;
                    Kaartcounter = 0;
                } else {
                    //Draai beide kaarten terug om
                    DraaiKaartenTerug();
                }
            }
            Render();
        }

        public static async void DraaiKaartenTerug() {
            await Task.Delay(2000); //TODO timer op beeld?
            ZetOmgedraaid(Kaart1x, Kaart1y, false);
            ZetOmgedraaid(Kaart2x, Kaart2y, false);
            Kaartcounter = 0;
        }

        public static void Render() {
            FormSpeelveld.Textbox_Score_Speler_1.Text = Convert.ToString(Score1);
            FormSpeelveld.Textbox_Score_Speler_2.Text = Convert.ToString(Score2);
            FormSpeelveld.Textbox_Zetten_Speler_1.Text = Convert.ToString(Zetten1);
            FormSpeelveld.Textbox_Zetten_Speler_2.Text = Convert.ToString(Zetten2);
        }

        public static async void Timer() {

        }

        private static void ZetOmgedraaid(int x, int y, bool omgedraaid) {
            Speelveld_omgedraaid[x, y] = omgedraaid;
            string kaartnaam = "Kaart" + x + "" + y;
            PictureBox box = ((PictureBox)FormSpeelveld.Controls[kaartnaam]);
            if (omgedraaid) {
                int kaarttype = Speelveld_types[x, y];
                box.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Kaart" + kaarttype);
            } else {
                box.Image = Properties.Resources.KaartVoorkant;
            }
        }
    }
}
