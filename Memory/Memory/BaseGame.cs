using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void InitSpeelveld(int h, int w) {
            Height = h;
            Width = w;
            Speelveld_types = new int[h, w];
            Speelveld_omgedraaid = new bool[h, w];
        }

        public static void InitForm() {
            FormSpeelveld = new FormSpeelveld();
        }

        public static void KaartKlik(int x, int y) {

        }

        public static async void ResetKaarten() {

        }

        public static void Render() {

        }

        public static async void Timer() {

        }
    }
}
