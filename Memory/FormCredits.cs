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
    public partial class FormCredits : Form
    {
        public FormCredits()
        {
            InitializeComponent();
        }

      
        /// <summary>
        /// zet de achtergrond van de form opde juiste foto voor het juiste thema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCredits_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "CreditsAchtergrond");
        }
        /// <summary>
        /// closed en disposed de form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Picturebox1Credits_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            GC.Collect();
        }
    }
}
