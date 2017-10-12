using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class BaseGame
    {
        FormSpeelveld FormSpeelveld;
        int Gamemode; // 0 = Singleplayer, 1 = Local, 2 = Online
        int[,] Speelveld_types;
        bool[,] Speelveld_omgedraaid;
        int Height;
        int Width;
        int Zetten;
        int Kaart;
        int Score1;
        int Score2;
        int Kaart1x;
        int Kaart1y;
        int Kaart2x;
        int Kaart2y;
        int Kaartcounter;
        string Naam1;
        string Naam2;
        int SpelerAanBeurt; // 1 = Speler 1, 2 = Speler 2
        
        void InitSpeelveld() {

        }

        void InitForm() {

        }

        void Click(int x, int y) {

        }

        async void Reset() {

        }

        void Render() {

        }

        async void Timer() {

        }
    }
}
