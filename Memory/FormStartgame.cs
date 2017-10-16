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
            if (comboGametype.Text == "Local Multiplayer" || comboGametype.Text == "Multiplayer Online")
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
            int h, w;
            BaseGame.Reset(); //Just in case
            if (comboGametype.Text != "Join Multiplayer") {
                switch (comboSpelgrootte.Text) {
                    //2x2 2x3 2x4 3x4 4x4
                    case "2x2":
                        h = 2;
                        w = 2;
                        break;
                    case "2x3":
                        h = 2;
                        w = 3;
                        break;
                    case "2x4":
                        h = 2;
                        w = 4;
                        break;
                    case "3x4":
                        h = 3;
                        w = 4;
                        break;
                    case "4x4":
                        h = 4;
                        w = 4;
                        break;
                    default:
                        MessageBox.Show("Voer de grootte van het speelveld in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
            }
            switch (comboGametype.Text) {
                case "Singleplayer":
                    string naam = textboxNaam1.Text;
                    if(naam == null || naam.Length == 0) {
                        naam = "Speler 1";
                    }
                    GameSingleplayer.Start(h, w, naam);
                    this.Close();
                    break;
                case "Local Multiplayer":
                    string naam1 = textboxNaam1.Text;
                    if (naam1 == null || naam1.Length == 0) {
                        naam1 = "Speler 1";
                    }
                    string naam2 = textboxNaam2.Text;
                    if (naam2 == null || naam2.Length == 0) {
                        naam2 = "Speler 2";
                    }
                    GameMultiplayerLocal.Start(h, w, naam1, naam2);
                    this.Close();
                    break;
                case "Host Multiplayer":
                    break;
                case "Join Multiplayer":
                    break;
                case "Kies spelmodus":
                    MessageBox.Show("Voer een spelmodus in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }
    }
}
