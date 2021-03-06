﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    class GameMultiplayerOnline
    {
        public static bool Host;
        /// <summary>
        /// Deze method start de online multiplayer game. de host krijgt eerst de naam van de client speler met het join packet, vervolgens antwoord de host met zijn naam en met de inhoud van he speelveld met het join2 packet.
        /// dan word het speelveld geopend.
        /// 
        /// <param name="Hoogte">Hoogte van het speelveld</param>
        /// <param name="Breedte">Breedte van het speelveld</param>
        /// <param name="Naam">De naam van de speler. Dit kan de client of de host zijn</param>
        /// <param name="host">Bepaald of de speler de client of de host is</param>
        public static async void Start(int Hoogte, int Breedte, string Naam, bool host) {
            Host = host;
            BaseGame.Gamemode = 2;

            //Join packet
            if (!host) {   //client side
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
            } else {  //host side
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
            BaseGame.FormSpeelveld.PictureBox_Opslaan_En_Exit.Hide();
            BaseGame.FormSpeelveld.PictureBox_Reset.Hide();
            BaseGame.FormSpeelveld.restartToolStripMenuItem.HideDropDown();
            BaseGame.FormSpeelveld.Label_Timer.Hide();
            BaseGame.FormSpeelveld.Label_Timer.Hide();
            
            BaseGame.Gamestate = 1;
            BaseGame.FormSpeelveld.Label_Score_Speler_1.Text = BaseGame.Naam1 + " : ";
            BaseGame.FormSpeelveld.Label_Score_Speler_2.Text = BaseGame.Naam2 + " : ";
            //BaseGame.Timer();
            BaseGame.Render();

            KlaarVoorVolgendeKlikkaart();
        }

        /// <summary>
        /// wordt gecalled als er iemand op een kaart klikt
        /// </summary>
        /// <param name="x">De x van de kaart</param>
        /// <param name="y">De y van de kaart</param>
        /// <returns>True als de logica in basegame niet door moet gaan, anders false</returns>
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

        /// <summary>
        /// deze methode wisselt de beurt van de spelers als 2 getrokken kaarten niet gelijk aan elkaar zijn.
        /// de client of de host sturen het volgendebeurt packet (hangt er van af wie aan de beurt was) de ander luistert.
        /// 
        /// </summary>
        public static void VolgendeBeurt() {
            //Als de kaarten niet gelijk zijn is volgende aan beurt
            if (BaseGame.Speelveld_types[BaseGame.Kaart1x, BaseGame.Kaart1y] != BaseGame.Speelveld_types[BaseGame.Kaart2x, BaseGame.Kaart2y]) {
                //Coole syntax om speler aan beurt te switchen tussen 1 en 2
                BaseGame.SpelerAanBeurt = BaseGame.SpelerAanBeurt == 1 ? 2 : 1;  //1 ? 2 : 1 als het 1 is word het 2, als het 2 is word het 1.
            }

            //Stuur volgendebeurt packet
            object[] volgendebeurt = new object[2];
            volgendebeurt[0] = "volgendebeurt";
            volgendebeurt[1] = BaseGame.SpelerAanBeurt;
            if (Host) {
                NetServer.SendMessage(Utils.ArrayToString(volgendebeurt));
            } else {
                NetClient.SendMessage(Utils.ArrayToString(volgendebeurt));
            }
        }

        /// <summary>
        /// Wacht op een klikkaart packet van de andere speler
        /// Als die gekregen is voert hij de logica uit die nodig is
        /// </summary>
        public static void KlaarVoorVolgendeKlikkaart() {
            //Als deze speler niet aan de beurt is
            if ((Host ? 1 : 2) != BaseGame.SpelerAanBeurt) {  // ((Host ? 1 : 2) als de host true is dan 1 zo niet dan 2
                //Wacht op klik kaart packets van andere kant
                BackgroundWorker b = new BackgroundWorker();

                //Wordt op tweede thread gerunned
                b.DoWork += delegate (object o, DoWorkEventArgs args) {  //doe dit op achtergrond  (delegate is mini method in method)
                    BackgroundWorker bw = o as BackgroundWorker;
                    object[] packet;
                    if (Host) {
                        packet = Utils.StringToArray(NetServer.ReceiveMessage()) as object[];
                    } else {
                        packet = Utils.StringToArray(NetClient.ReceiveMessage()) as object[];
                    }
                    args.Result = packet;
                };

                //Als er een bericht is binnen gekomen
                b.RunWorkerCompleted += delegate (object o, RunWorkerCompletedEventArgs args) { //achtergrond shit is klaar
                    object[] packet = (object[]) args.Result;
                    //Is het een klik kaart, of een volgende beurt packet?
                    if(((string) packet[0]) == "klikkaart") {
                        //Update speelveld
                        BaseGame.KaartKlik((int)packet[1], (int)packet[2], false);
                    } else if(((string)packet[0]) == "volgendebeurt") {
                        //Zet speler aan beurt goed
                        BaseGame.SpelerAanBeurt = (int)packet[1];
                    }

                    //Klaar voor volgende beurt
                    if(BaseGame.Gamestate == 1) KlaarVoorVolgendeKlikkaart();
                };
                b.RunWorkerAsync();
            }
        }

        /// <summary>
        /// Eindigt de game
        /// Als dit de client is, wacht op een reset packet van de host
        /// </summary>
        public static async void End() {
            BaseGame.Gamestate = 2;
            await Task.Delay(2000);

            //Als het een client is, wacht op reset packet van host
            if (!Host) {
                BackgroundWorker b = new BackgroundWorker();

                //Wordt op tweede thread gerunned
                b.DoWork += delegate (object o, DoWorkEventArgs args) {
                    BackgroundWorker bw = o as BackgroundWorker;
                    object[] reset = Utils.StringToArray(NetClient.ReceiveMessage()) as object[];
                    args.Result = reset;
                };

                //Als er een bericht is binnen gekomen
                b.RunWorkerCompleted += delegate (object o, RunWorkerCompletedEventArgs args) {
                    object[] reset = (object[])args.Result;
                    if ((reset[0] as string) == "reset") {
                        BaseGame.Reset();
                        FormEndgame.instance.Close();
                        FormEndgame.instance.Dispose();
                        Start(BaseGame.Height, BaseGame.Width, BaseGame.Naam2, false);
                    }
                };
                b.RunWorkerAsync();
            }

            Exit();
        }

        /// <summary>
        /// Sluit de game abrupt af
        /// </summary>
        public static void Exit()
        {
            BaseGame.Gamestate = 2;
            BaseGame.FormSpeelveld.Close();
            BaseGame.FormSpeelveld.Dispose();
            GC.Collect();
            FormEndgame endgame = new FormEndgame();
            endgame.ShowDialog();
        }

        /// <summary>
        /// Wordt gecalled als er iemand op de reset knop drukt
        /// </summary>
        /// <returns></returns>
        public static bool Reset() {
            if (Host) {
                return false;
            } else {
                MessageBox.Show("Alleen de host kan de game opnieuw opstarten", "Memory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        /// <summary>
        /// Stuurt een reset packet van de host naar die client
        /// </summary>
        public static void Reset2() {
            if (Host) {
                object[] reset = new object[1];
                reset[0] = "reset";
                NetServer.SendMessage(Utils.ArrayToString(reset));
                Start(BaseGame.Height, BaseGame.Width, BaseGame.Naam1, true);
            }
        }

        /// <summary>
        /// Disconnect de huidige speler
        /// </summary>
        public static void Disconnect() {
            if (Host) {
                NetServer.Disconnect();
            } else {
                NetClient.Disconnect();
            }
        }
    }
}
