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
    public partial class FormMenu : Form
    {
        public static FormMenu Menu;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e) {
            FormMenu.Menu = this;
        }

        

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            FormStartgame startgame = new FormStartgame();
            startgame.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
