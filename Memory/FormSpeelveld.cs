using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class FormSpeelveld : Form
    {
        public FormSpeelveld()
        {
            double yTussenruimte = -35;
            double xTussenruimte = 25;
            double xSizeTemp = 175;
            double ySizeTemp = 263;
            InitializeComponent();
            PictureBox[,] Kaart = new PictureBox[BaseGame.Width, BaseGame.Height];
            if (BaseGame.Width == 2 && BaseGame.Height == 2) //speelveld 2x2
            {
                xSizeTemp *= 2;
                ySizeTemp *= 2;
            }
            else if (BaseGame.Width == 3 && BaseGame.Height == 2) //speelveld 2x3
            {
                xSizeTemp *= 1.25;
                ySizeTemp *= 1.25;
            }

            int yLocation = 5;
            for (int y = 0; y < BaseGame.Height; y++)
            {
                int xLocation = 366;
                for (int x = 0; x < BaseGame.Width; x++)
                {
                    string Kaartnaam = "Kaart" + x + "" + y;
                    Kaart[x, y] = new PictureBox();
                    Kaart[x, y].Name = Kaartnaam;
                    Kaart[x, y].Size = new Size(Convert.ToInt32(xSizeTemp), Convert.ToInt32(ySizeTemp));
                    Kaart[x, y].Image = Properties.Resources.KaartVoorkant;
                    Kaart[x, y].BackColor = Color.Transparent;
                    Kaart[x, y].Visible = true;
                    Kaart[x, y].Anchor = AnchorStyles.Left;
                    Kaart[x, y].SizeMode = PictureBoxSizeMode.Zoom;
                    Kaart[x, y].Location = new Point(xLocation, yLocation);
                    Kaart[x, y].BringToFront();
                    string eventnaam = Kaartnaam + "_Click";
                    int x2 = x;
                    int y2 = y;
                    Kaart[x, y].Click += new EventHandler((sender, e) => {
                        BaseGame.KaartKlik(x2, y2);
                    });
                    this.Controls.Add(Kaart[x, y]);
                    xLocation += Convert.ToInt32(xSizeTemp) + Convert.ToInt32(xTussenruimte);
                }
                yLocation += Convert.ToInt32(ySizeTemp) + Convert.ToInt32(yTussenruimte);
            }





        }

        private void Button_Exit_Click(object sender, EventArgs e) {
            BaseGame.Endgame();
        }

        private void Button_Opslaan_Click(object sender, EventArgs e) {
            SaveGameManager.SaveEnEnd();
            
        }
    }
}
