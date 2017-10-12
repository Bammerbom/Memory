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
    public partial class FormEndgame : Form
    {
        public FormEndgame()
        {
            InitializeComponent();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {

        }

        private void ButtonStartgame_Click(object sender, EventArgs e)
        {
            this.Close();
            FormStartgame startgame = new FormStartgame();
            startgame.Show();
        }

        private void ButtonHighscored_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHighscores highscores = new FormHighscores();
            highscores.Show();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu.Menu.Show();
        }
    }
}
