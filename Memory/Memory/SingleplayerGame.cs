using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class SingleplayerGame
    {
        private static FormSpeelveld Form;
        private static List<int> KaartenIds;

        private static string Player;
        private static int Height;
        private static int Width;

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
                KaartenIds.Add(i + 1);
                KaartenIds.Add(i + 1);
            }
            KaartenIds = Utils.ShuffleList(KaartenIds);

            //Maak speelveld klaar
            Form = new FormSpeelveld();
            Form.Show();

            Form.Label_Score_Speler_1.Text = SingleplayerGame.Player + " :";
            Form.Label_Score_Speler_2.Visible = false;
            Form.Textbox_Score_Speler_2.Visible = false;
            Form.TextBox_Beurt.Visible = false;
        }

        public static void KaartKlik(int nummer)
        {
            int num = nummer;
            switch (num)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:

                    break;
                case 11:

                    break;
                case 12:

                    break;
                case 13:

                    break;
                case 14:

                    break;
                case 15:

                    break;

            }


        }
    }
}
