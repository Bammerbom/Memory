using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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
            this.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(ThemaManager.Themaprefix + "StartGameAchtergrond");
            comboGametype.Text = "Kies spelmodus";
            comboSpelgrootte.Visible = false;
            labelSpelgrootte.Visible = false;
            textboxNaam1.Visible = false;
            textboxNaam2.Visible = false;
            labelNaam1.Visible = false;
            labelNaam2.Visible = false;
        }

        private string GetLocalIPAddress() {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork) {
                    return ip.ToString();
                }
            }
            return "";
        }

        private void gametype_SelectedIndexChanged(object sender, EventArgs e) {
            if(comboGametype.Text == "Kies spelmodus")
            {
                comboSpelgrootte.Visible = false;
                labelSpelgrootte.Visible = false;
                textboxNaam1.Visible = false;
                textboxNaam2.Visible = false;
                labelNaam1.Visible = false;
                labelNaam2.Visible = false;
                labelIp.Visible = false;
                textboxIp.Visible = false;
                labelPort.Visible = false;
                textboxPort.Visible = false;
            }
            else if(comboGametype.Text == "Singleplayer")
            {
                comboSpelgrootte.Visible = true;
                labelSpelgrootte.Visible = true;
                textboxNaam1.Visible = true;
                labelNaam1.Text = "Naam invullen";
                labelNaam1.Visible = true;
                textboxNaam2.Visible = false;
                labelNaam2.Visible = false;
                labelIp.Visible = false;
                textboxIp.Visible = false;
                labelPort.Visible = false;
                textboxPort.Visible = false;
            }
            else if (comboGametype.Text == "Local Multiplayer")
            {
                comboSpelgrootte.Visible = true;
                labelSpelgrootte.Visible = true;
                textboxNaam1.Visible = true;
                textboxNaam2.Visible = true;
                labelNaam1.Text = "Naam 1 invullen";
                labelNaam1.Visible = true;
                labelNaam2.Visible = true;
                labelIp.Visible = false;
                textboxIp.Visible = false;
                labelPort.Visible = false;
                textboxPort.Visible = false;
            }
            else if(comboGametype.Text == "Host Multiplayer") {
                comboSpelgrootte.Visible = true;
                labelSpelgrootte.Visible = true;
                textboxNaam1.Visible = true;
                labelNaam1.Text = "Naam invullen";
                labelNaam1.Visible = true;
                textboxNaam2.Visible = false;
                labelNaam2.Visible = false;
                labelIp.Visible = true;
                textboxIp.Visible = true;
                labelPort.Visible = true;
                textboxPort.Visible = true;
                textboxIp.Text = GetLocalIPAddress();
                textboxIp.ReadOnly = true;
            }
            else if (comboGametype.Text == "Join Multiplayer") {
                comboSpelgrootte.Visible = false;
                labelSpelgrootte.Visible = false;
                textboxNaam1.Visible = true;
                labelNaam1.Text = "Naam invullen";
                labelNaam1.Visible = true;
                textboxNaam2.Visible = false;
                labelNaam2.Visible = false;
                labelIp.Visible = true;
                textboxIp.Visible = true;
                labelPort.Visible = true;
                textboxPort.Visible = true;
                textboxIp.Text = "";
                textboxIp.ReadOnly = false;
            }
        }

        private void pictureBoxStartmenuTerug_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void textboxNaam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBoxStartmenuStart_Click_1(object sender, EventArgs e)
        {
            int h, w;
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
            } else {
                h = 0;
                w = 0;
            }
            switch (comboGametype.Text) {
                case "Singleplayer":
                    string naam = textboxNaam1.Text;
                    if(naam == null || naam.Length == 0) {
                        naam = "Speler 1";
                    }
                    GameSingleplayer.Start(h, w, naam);
                    this.Close();
                    this.Dispose();
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
                    this.Dispose();
                    break;
                case "Host Multiplayer":
                    string naams = textboxNaam1.Text;
                    if (naams == null || naams.Length == 0) {
                        naams = "Speler 1";
                    }
                    int port = (int) textboxPort.Value;
                    if (ManagerServer.Server(port)) {
                        GameMultiplayerOnline.Start(h, w, naams, true);
                        this.Close();
                        this.Dispose();
                    }
                    //Errorbox wordt weergegeven door Server method
                    break;
                case "Join Multiplayer":
                    string naamt = textboxNaam1.Text;
                    if (naamt == null || naamt.Length == 0) {
                        naamt = "Speler 2";
                    }
                    string ip = textboxIp.Text;
                    int port2 = (int)textboxPort.Value;
                    if (ManagerClient.Client(ip, port2)) {
                        GameMultiplayerOnline.Start(h, w, naamt, false);
                        this.Close();
                        this.Dispose();
                    }
                    //Errorbox wordt weergegeven dooe Client method
                    break;
                case "Kies spelmodus":
                    MessageBox.Show("Voer een spelmodus in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

            }
        }

        
    }
}
