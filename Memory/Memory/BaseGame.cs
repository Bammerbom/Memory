﻿using System;
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

        public static void InitSpeelveld(int h, int w) {
            Height = h;
            Width = w;
            Speelveld_types = new int[h, w];
            Speelveld_omgedraaid = new bool[h, w];
            //TODO vullen
        }

        public static void InitForm() {
            FormSpeelveld = new FormSpeelveld();
            FormSpeelveld.Show();
        }

        public static void KaartKlik(int x, int y) {
            if (Speelveld_omgedraaid[x, y] == true) return; //Negeer klikken op kaart als de kaart al omgedraait is
            if (Kaartcounter == 2) return; //Negeer als er al 2 kaarten omgedraait zijn

            //Keer kaart om
            Speelveld_omgedraaid[x, y] = true;

            Kaartcounter++;
            if (Kaartcounter == 1) {
                //Sla eerste kaart op
                Kaart1x = x;
                Kaart1y = y;
            } else if (Kaartcounter == 2) {
                //Sla tweede kaart op
                Kaart2x = x;
                Kaart2y = y;

                //Kijk of kaarten gelijk zijn
                if (Speelveld_omgedraaid[Kaart1x, Kaart1y] == Speelveld_omgedraaid[Kaart2x, Kaart2y]) {
                    //Voeg 1 bij de score toe
                    if (SpelerAanBeurt == 1) Score1++;
                    if (SpelerAanBeurt == 2) Score2++;
                    Kaartcounter = 0;
                } else {
                    //Draai beide kaarten terug om
                    DraaiKaartenTerug();
                }
            }
        }

        public static async void DraaiKaartenTerug() {
            await Task.Delay(2000); //TODO timer op beeld?
            Speelveld_omgedraaid[Kaart1x, Kaart1y] = false;
            Speelveld_omgedraaid[Kaart2x, Kaart2y] = false;
            
        }

        public static void Render() {
            Form.Textbox_Score_Speler_1.Text = Convert.ToString(score1);
            Form.Textbox_Score_Speler_2.Text = Convert.ToString(score2);
            Form.Textbox_Zetten.Text = Convert.ToString(zetten);

        }

        public static async void Timer() {

        }

        private static void ZetOmgedraaid(int x, int y, bool omgedraaid) {
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