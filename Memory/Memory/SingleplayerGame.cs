using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    class SingleplayerGame
    {
        private static FormSpeelveld Form;
        private static List<int> KaartenIds;

        private static string Player;
        private static int Height;
        private static int Width;
        private static int Kaart1, Kaart2;
        public static int kaartcounter, score, zetten;
        public static void Init(string player, int h, int w)
        {
            SingleplayerGame.Player = player;
            SingleplayerGame.Height = h;
            SingleplayerGame.Width = w;
        }

        public static void Start()
        {
            //Init lijst KaartenIds
            int kaarten = Height * Width / 2;
            KaartenIds = new List<int>();
            for (int i = 0; i < kaarten; i++)
            {
                KaartenIds.Add(i);
                KaartenIds.Add(i);
            }
            KaartenIds = Utils.ShuffleList(KaartenIds);

            //kaart counter reset
            kaartcounter = 0;
            //Maak speelveld klaar
            Form = new FormSpeelveld();
            Form.Show();

            Form.Label_Score_Speler_1.Text = SingleplayerGame.Player + " :";
            Form.Label_Score_Speler_2.Visible = false;
            Form.Textbox_Score_Speler_2.Visible = false;
            Form.TextBox_Beurt.Visible = false;
        }

        //draai kaart om

        public static void KaartKlik(int nummer)
        {
            int num = nummer;
            string kaart = "Kaart" + KaartenIds[num];
            string kaartnum = "Kaart" + num;
            ((PictureBox)Form.Controls[kaartnum]).Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);


            kaartcounter++;

            if (kaartcounter == 1)
            {
                Kaart1 = KaartenIds[num];
            }

            if (kaartcounter == 2)
            {
                kaartcounter = 0;
                Kaart2 = KaartenIds[num];

                zetten++;

                if (Kaart1 == Kaart2)
                {
                    score++;

                }
                else
                {
                    KaartReset();
                }
                Gameupdate();

            }


        }

        public static void Gameupdate()
        {
            Form.Textbox_Score_Speler_1.Text = Convert.ToString(score);
            Form.Textbox_Zetten.Text = Convert.ToString(zetten);

        }

        public static void KaartReset()
        {
            
            for (int i = 0; i <KaartenIds.Count; i++)
            {
                string kaart = "Kaart" + i;
                ((PictureBox)Form.Controls[kaart]).Image = Properties.Resources.Voorkant_Memory_kaart;

            }
        }
        
        
    }
}
