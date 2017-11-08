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
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }
        


        /// <summary>
        /// select de juiste achtergrond en tekstkleur voor het gekozen thema tijdens het laden van de form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormHelp_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "HelpAchtergrond");

            




        }



     
        /// <summary>
        /// closed en disposed de form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("TerugButtonBlauw2D");
            await Task.Delay(300);
            this.pictureBox1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("TerugButtonBlauw");
            this.Close();
            this.Dispose();
            GC.Collect();
        }

        
    }
}
