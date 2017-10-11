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

            Form.Label_Score_Speler_1.Text = "Hoi";
        }

        //draai kaart om

        public static void KaartKlik(int nummer)
        {
            int num = nummer;
            string kaart = "Kaart" + KaartenIds[num];

            switch (num)
            {
                case 0:
                    Form.Kaart0.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);

                    break;
                case 1:
                    Form.Kaart1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);
                    break;
                case 2:
                    Form.Kaart2.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);
                    break;
                case 3:
                    Form.Kaart3.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);
                    break;
                case 4:
                    Form.Kaart4.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);
                    break;
                case 5:
                    Form.Kaart5.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);
                    break;
                case 6:
                    Form.Kaart6.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);
                    break;
                case 7:
                    Form.Kaart7.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);
                    break;
                case 8:
                    Form.Kaart8.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);
                    break;
                case 9:
                    Form.Kaart9.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);
                    break;
                case 10:
                    Form.Kaart10.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);
                    break;
                case 11:
                    Form.Kaart11.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);
                    break;
                case 12:
                    Form.Kaart12.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);
                    break;
                case 13:
                    Form.Kaart13.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);
                    break;
                case 14:
                    Form.Kaart14.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);
                    break;
                case 15:
                    Form.Kaart15.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(kaart);
                    break;

            }

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
            System.Threading.Thread.Sleep(3000);
            for (int i = 0; i <KaartenIds.Count; i++)
            {
                string kaart = "Kaart" + i;
                ((PictureBox)Form.Controls[kaart]).Image = Properties.Resources.Voorkant_Memory_kaart;

            }
        }
        
        
    }
}
