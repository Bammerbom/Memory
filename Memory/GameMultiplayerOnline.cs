using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                BaseGame.InitSpeelveld(Hoogte, Breedte);

                //HOST krijgt join
                BaseGame.Naam1 = Naam;
                object[] join = Utils.StringToArray(NetServer.ReceiveMessage()) as object[];
                BaseGame.Naam2 = (string) join[1];

                //HOST stuurt join2
                object[] join2 = new object[6];
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

            KlaarVoorVolgendeKlikkaart();
        }

        public static bool KlikKaart(int x, int y) {
            //Als de speler niet aan de beurt is, return true
            if ((Host ? 1 : 2) != BaseGame.SpelerAanBeurt) return true;

            //Maak packet
            object[] klikkaart = new object[3];
            klikkaart[0] = "klikkaart";
            klikkaart[1] = x;
            klikkaart[2] = y;

            //Stuur packet
            if (Host) {
                NetServer.SendMessage(Utils.ArrayToString(klikkaart));
            } else {
                NetClient.SendMessage(Utils.ArrayToString(klikkaart));
            }
            return false;
        }

        public static void VolgendeBeurt() {
            //Als de kaarten niet gelijk zijn
            if (BaseGame.Speelveld_types[BaseGame.Kaart1x, BaseGame.Kaart1y] != BaseGame.Speelveld_types[BaseGame.Kaart2x, BaseGame.Kaart2y]) {
                //Coole syntax om speler aan beurt te switchen tussen 1 en 2
                BaseGame.SpelerAanBeurt = BaseGame.SpelerAanBeurt == 1 ? 2 : 1;
            }
        }

        public static void KlaarVoorVolgendeKlikkaart() {
            //Als deze speler aan de beurt is
            if ((Host ? 1 : 2) == BaseGame.SpelerAanBeurt) {
                //Niks
            } else {
                //Wacht op klik kaart packets van andere kant
                BackgroundWorker b = new BackgroundWorker();
                b.DoWork += delegate (object o, DoWorkEventArgs args) {
                    BackgroundWorker bw = o as BackgroundWorker;
                    object[] klikkaart;
                    if (Host) {
                        klikkaart = Utils.StringToArray(NetServer.ReceiveMessage()) as object[];
                    } else {
                        klikkaart = Utils.StringToArray(NetClient.ReceiveMessage()) as object[];
                    }
                    args.Result = klikkaart;
                };
                b.RunWorkerCompleted += delegate (object o, RunWorkerCompletedEventArgs args) {
                    object[] klikkaart = (object[]) args.Result;
                    BaseGame.KaartKlik((int)klikkaart[1], (int)klikkaart[2], false);
                };
                b.RunWorkerAsync();
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
