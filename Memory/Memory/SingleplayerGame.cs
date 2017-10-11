using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class SingleplayerGame
    {
        private FormSpeelveld Form;
        private List<int> KaartenIds;

        private string Player;
        private int Height;
        private int Width;

        public SingleplayerGame(string player, int h, int w) {
            this.Player = player;
            this.Height = h;
            this.Width = w;
        }

        public void Start() {
            //Init lijst KaartenIds
            int kaarten = Height * Width / 2;
            KaartenIds = new List<int>();
            for(int i = 0; i < kaarten; i++) {
                KaartenIds.Add(i + 1);
                KaartenIds.Add(i + 1);
            }
            KaartenIds = Utils.ShuffleList(KaartenIds);

            //Maak speelveld klaar
            Form = new FormSpeelveld();
            Form.Show();

        }

    }
}
