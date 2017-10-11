﻿using System;
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
    public partial class FormStartgame : Form
    {
        public FormStartgame() {
            InitializeComponent();
        }

        private void FormStartgame_Load(object sender, EventArgs e) {
            
        }

        private void gametype_SelectedIndexChanged(object sender, EventArgs e) {
            Console.WriteLine(comboGametype.Text);
        }

        private void buttonTerug_Click(object sender, EventArgs e) {
            this.Close();
            FormMenu.Menu.Show();
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            switch (comboGametype.Text) {
                case "Singleplayer":
                    SingleplayerGame.Init("Speler", 4, 4); //TODO goede argumenten
                    SingleplayerGame.Start();
                    this.Close();
                    break;
                default:
                    //TODO geef error met niks geselecteerd
                    break;
            }
        }
    }
}
