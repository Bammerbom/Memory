using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class GameMultiplayerOnline
    {
        public static bool Host;
        public static void Start(int Hoogte, int Breedte, string Naam, bool host) {
            Host = host;
            BaseGame.Gamemode = 2;
            string Naam1, Naam2;

            //Join packet
            if (!host) {
                Naam2 = Naam;
                string[] join = new string[2];
                join[0] = "join"; //Packet
                join[1] = Naam; //Naam
                NetClient.SendMessage(Utils.ArrayToString(join));

                string[] join2 = Utils.StringToArray(NetClient.ReceiveMessage()) as string[];
                Naam1 = join2[1];
            } else {
                Naam1 = Naam;
                string[] join = Utils.StringToArray(NetClient.ReceiveMessage()) as string[];
                Naam2 = join[1];

                string[] join2 = new string[2];
                join2[0] = "join2"; //Packet
                join2[1] = Naam; //Naam
                NetClient.SendMessage(Utils.ArrayToString(join2));
            }

            BaseGame.InitSpeelveld(Hoogte, Breedte);
            BaseGame.InitForm();
            BaseGame.SpelerAanBeurt = Utils.rand.Next(1, 3);
            BaseGame.Gamestate = 1;
            BaseGame.Naam1 = Naam1;
            BaseGame.Naam2 = Naam2;
            BaseGame.FormSpeelveld.Label_Score_Speler_1.Text = Naam1 + " : ";
            BaseGame.FormSpeelveld.Label_Score_Speler_2.Text = Naam2 + " : ";
            BaseGame.Timer();
            BaseGame.Render();
        }

        public static void VolgendeBeurt() {
            //Als de kaarten niet gelijk zijn
            if (BaseGame.Speelveld_types[BaseGame.Kaart1x, BaseGame.Kaart1y] != BaseGame.Speelveld_types[BaseGame.Kaart2x, BaseGame.Kaart2y]) {
                //Coole syntax om speler aan beurt te switchen tussen 1 en 2
                BaseGame.SpelerAanBeurt = BaseGame.SpelerAanBeurt == 1 ? 2 : 1;
            }
        }

        public static void End() {

        }
    }
}
