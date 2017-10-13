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

        private void FormStartgame_Load(object sender, EventArgs e) {
            
        }

        private void gametype_SelectedIndexChanged(object sender, EventArgs e) {
            Console.WriteLine(comboGametype.Text);
        }

        private void buttonTerug_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            switch (comboGametype.Text) {
                case "Singleplayer":
                    string naam = inputANaam.Text;
                    if(naam == null || naam.Length == 0) {
                        naam = "Speler 1";
                    }
                    switch (comboASpelgrootte.Text) {
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
                            MessageBox.Show("Voer een spelgrootte in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    this.Close();
                    break;
                default:
                    MessageBox.Show("Voer een gamemode in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }
    }
}
