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

            //Join packet
            if (!host) {
                //CLIENT stuurt join
                BaseGame.Naam2 = Naam;
                object[] join = new object[2];
                join[0] = "join"; //Packet
                join[1] = Naam; //Naam
                NetClient.SendMessage(Utils.ArrayToString(join));

                //CLIENT krijgt join2
                object[] join2 = Utils.StringToArray(NetClient.ReceiveMessage()) as object[];
                BaseGame.Naam1 = (string) join2[1];
                BaseGame.InitSpeelveld((int)join2[2], (int)join2[3]);
                BaseGame.Speelveld_types = Utils.StringToArray((string)join2[4]) as int[,];
                BaseGame.SpelerAanBeurt = (int)join2[5];
            } else {
                //Init
                BaseGame.SpelerAanBeurt = Utils.rand.Next(1, 3);

                //HOST krijgt join
                BaseGame.Naam1 = Naam;
                string[] join = Utils.StringToArray(NetServer.ReceiveMessage()) as string[];
                BaseGame.Naam2 = join[1];

                //HOST stuurt join2
                object[] join2 = new object[2];
                join2[0] = "join2"; //Packet
                join2[1] = Naam; //Naam
                join2[2] = Hoogte;
                join2[3] = Breedte;
                join2[4] = Utils.ArrayToString(BaseGame.Speelveld_types);
                join2[5] = BaseGame.SpelerAanBeurt;
                NetServer.SendMessage(Utils.ArrayToString(join2));
            }

            BaseGame.InitForm();
            
            BaseGame.Gamestate = 1;
            BaseGame.FormSpeelveld.Label_Score_Speler_1.Text = BaseGame.Naam1 + " : ";
            BaseGame.FormSpeelveld.Label_Score_Speler_2.Text = BaseGame.Naam2 + " : ";
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

        public static async void End() {
            BaseGame.Gamestate = 2;
            await Task.Delay(2000);
            BaseGame.FormSpeelveld.Close();
            FormEndgame endgame = new FormEndgame();
            endgame.Show();
        }
    }
}
