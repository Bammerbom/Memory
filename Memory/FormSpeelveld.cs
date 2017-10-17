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
            int xLocation = 366;
            int yLocation = 17;
            InitializeComponent();
            PictureBox[,] Kaart = new PictureBox[BaseGame.Width, BaseGame.Height];
            for (int y = 0; y < BaseGame.Height; y++)
            {
                for(int x = 0; x < BaseGame.Width; x++)
                {
                    string Kaartnaam = "Kaart" + x + "" + y;
                    Kaart[y, x] = new PictureBox();
                    Kaart[y, x].Name = Kaartnaam;
                    Kaart[y, x].Size = new Size(175, 262);
                    Kaart[y, x].BackgroundImage = Properties.Resources.KaartVoorkant;
                    Kaart[y, x].BackColor = Color.Transparent;
                    Kaart[y, x].Visible = true;
                    Kaart[y, x].Anchor = AnchorStyles.Left;
                    Kaart[y, x].BackgroundImageLayout = ImageLayout.Zoom;
                    Kaart[y, x].Location = new Point(xLocation, yLocation);
                    Kaart[y, x].BringToFront();
                    this.Controls.Add(Kaart[y, x]);
                    xLocation += 200;
                }
                xLocation = 366;
                yLocation += 235;
            }

        }

        private void Kaart00_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(0,0);
        }

        private void Kaart01_Click(object sender, EventArgs e)
        {

            BaseGame.KaartKlik(1,0);
        }

        private void Kaart2_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(2,0);
        }

        private void Kaart3_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(3,0);
        }

        private void Kaart4_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(0,1);
        }

        private void Kaart5_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(1,1);
        }

        private void Kaart6_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(2,1);
        }

        private void Kaart7_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(3,1);
        }

        private void Kaart8_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(0,2);
        }

        private void Kaart9_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(1,2);
        }

        private void Kaart10_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(2,2);
        }

        private void Kaart11_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(3,2);
        }

        private void Kaart12_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(0,3);
        }

        private void Kaart13_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(1,3);
        }

        private void Kaart14_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(2,3);
        }

        private void Kaart15_Click(object sender, EventArgs e)
        {
            BaseGame.KaartKlik(3,3);
        }

        private void Button_Exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Button_Opslaan_Click(object sender, EventArgs e) {
            this.Close();
            //TODO save
        }
    }
}
