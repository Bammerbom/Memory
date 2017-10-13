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
    public partial class FormStartgame : Form
    {
        public FormStartgame() {
            InitializeComponent();
        }

        private void FormStartgame_Load(object sender, EventArgs e)
        {
            comboGametype.Text = "Kies spelmodus";
            comboSpelgrootte.Visible = false;
            labelSpelgrootte.Visible = false;
            textboxNaam1.Visible = false;
            textboxNaam2.Visible = false;
            labelNaam1.Visible = false;
            labelNaam2.Visible = false;
        }

        private void gametype_SelectedIndexChanged(object sender, EventArgs e) {
            Console.WriteLine(comboGametype.Text);
            if(comboGametype.Text == "Kies spelmodus")
            {
                comboSpelgrootte.Visible = false;
                labelSpelgrootte.Visible = false;
                textboxNaam1.Visible = false;
                textboxNaam2.Visible = false;
                labelNaam1.Visible = false;
                labelNaam2.Visible = false;
            }
            if(comboGametype.Text == "Singleplayer")
            {
                comboSpelgrootte.Visible = true;
                labelSpelgrootte.Visible = true;
                textboxNaam1.Visible = true;
                labelNaam1.Text = "Naam invullen";
                labelNaam1.Visible = true;
                textboxNaam2.Visible = false;
                labelNaam2.Visible = false;
            }
            if (comboGametype.Text == "Multiplayer Local" || comboGametype.Text == "Multiplayer Online")
            {
                comboSpelgrootte.Visible = true;
                labelSpelgrootte.Visible = true;
                textboxNaam1.Visible = true;
                textboxNaam2.Visible = true;
                labelNaam1.Text = "Naam 1 invullen";
                labelNaam1.Visible = true;
                labelNaam2.Visible = true;
            }

        }

        private void buttonTerug_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            switch (comboGametype.Text) {
                default:
                    string naam = textboxNaam1.Text;
                    if(naam == null || naam.Length == 0) {
                        naam = "Speler 1";
                    }
                    switch (comboSpelgrootte.Text) {
                        //2x2 2x3 2x4 3x4 4x4
                        case "2x2":
                            GameSingleplayer.Start(2, 2, naam);
                            break;
                        case "2x3":
                            GameSingleplayer.Start(2, 3, naam);
                            break;
                        case "2x4":
                            GameSingleplayer.Start(2, 4, naam);
                            break;
                        case "3x4":
                            GameSingleplayer.Start(3, 4, naam);
                            break;
                        case "4x4":
                            GameSingleplayer.Start(4, 4, naam);
                            break;
                        default:
                            MessageBox.Show("Voer de grootte van het speelveld in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    this.Close();
                    break;
                case "Kies spelmodus":
                    MessageBox.Show("Voer een spelmodus in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }
    }
}
