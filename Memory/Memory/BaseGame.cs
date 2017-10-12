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
        public static int Zetten1;
        public static int Zetten2;
        public static int Kaart;
        public static int Score1;
        public static int Score2;
        public static int Kaart1x;
        public static int Kaart1y;
        public static int Kaart2x;
        public static int Kaart2y;
        public static int Kaartcounter;
        public static string Naam1;
        public static string Naam2;
        public static int SpelerAanBeurt; // 1 = Speler 1, 2 = Speler 2

        public static void InitSpeelveld() {

        }

        public static void InitForm() {

        }

        public static void Click(int x, int y) {

        }

        public static async void Reset() {

        }

        public static void Render() {

        }

        public static async void Timer() {

        }
    }
}
