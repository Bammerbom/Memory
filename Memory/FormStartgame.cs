using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class FormStartgame : Form
    {
        /// <summary>
        /// intialized components
        /// </summary>
        public FormStartgame() {
            InitializeComponent();
        }

        /// <summary>
        /// load het juiste thema en hide alle textboxes en dropdownmenu's
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormStartgame_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "StartGameAchtergrond");
            comboGametype.Text = "Kies spelmodus";
            comboSpelgrootte.Visible = false;
            pictureBoxSpeelveld.Visible = false;
            textboxNaam1.Visible = false;
            textboxNaam2.Visible = false;
            pictureBoxNaam1.Visible = false;
            pictureBoxNaam2.Visible = false;
        }

        /// <summary>
        /// zoekt het lokale ip adres voor de online multiplayer host
        /// </summary>
        /// <returns></returns>
        private string GetLocalIPAddress() {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork) {
                    return ip.ToString();
                }
            }
            return "";
        }

        /// <summary>
        /// laat verschillende textboxes en dropdownmenu's zien bij het veranderen van de gamemmode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gametype_SelectedIndexChanged(object sender, EventArgs e) {
            if(comboGametype.Text == "Kies spelmodus")
            {
                comboSpelgrootte.Visible = false;
                pictureBoxSpeelveld.Visible = false;
                textboxNaam1.Visible = false;
                textboxNaam2.Visible = false;
                pictureBoxNaam1.Visible = false;
                pictureBoxNaam2.Visible = false;
                pictureBoxIPadres.Visible = false;
                textboxIp.Visible = false;
                pictureBoxPort.Visible = false;
                textboxPort.Visible = false;
            }
            else if(comboGametype.Text == "Singleplayer")
            {
                comboSpelgrootte.Visible = true;
                pictureBoxSpeelveld.Visible = true;
                textboxNaam1.Visible = true;
                pictureBoxNaam1.Text = "Naam invullen";
                pictureBoxNaam1.Visible = true;
                textboxNaam2.Visible = false;
                pictureBoxNaam2.Visible = false;
                pictureBoxIPadres.Visible = false;
                textboxIp.Visible = false;
                pictureBoxPort.Visible = false;
                textboxPort.Visible = false;
            }
            else if (comboGametype.Text == "Local Multiplayer")
            {
                comboSpelgrootte.Visible = true;
                pictureBoxSpeelveld.Visible = true;
                textboxNaam1.Visible = true;
                textboxNaam2.Visible = true;
                pictureBoxNaam1.Text = "Naam 1 invullen";
                pictureBoxNaam1.Visible = true;
                pictureBoxNaam2.Visible = true;
                textboxNaam2.MaxLength = 10;
                pictureBoxIPadres.Visible = false;
                textboxIp.Visible = false;
                pictureBoxPort.Visible = false;
                textboxPort.Visible = false;
            }
            else if(comboGametype.Text == "Host Multiplayer") {
                comboSpelgrootte.Visible = true;
                pictureBoxSpeelveld.Visible = true;
                textboxNaam1.Visible = true;
                pictureBoxNaam1.Text = "Naam invullen";
                pictureBoxNaam1.Visible = true;
                pictureBoxNaam2.Visible = true;
                textboxNaam2.Visible = false;
                pictureBoxNaam2.Visible = false;
                pictureBoxIPadres.Visible = true;
                textboxIp.Visible = true;
                pictureBoxPort.Visible = true;
                textboxPort.Visible = true;
                textboxIp.Text = GetLocalIPAddress();
                textboxIp.ReadOnly = true;
            }
            else if (comboGametype.Text == "Join Multiplayer") {
                comboSpelgrootte.Visible = false;
                pictureBoxSpeelveld.Visible = false;
                textboxNaam1.Visible = true;
                pictureBoxNaam1.Text = "Naam invullen";
                pictureBoxNaam1.Visible = true;
                pictureBoxNaam2.Visible = true;
                textboxNaam2.Visible = false;
                pictureBoxNaam2.Visible = false;
                pictureBoxIPadres.Visible = true;
                textboxIp.Visible = true;
                pictureBoxPort.Visible = true;
                textboxPort.Visible = true;
                textboxIp.Text = "";
                textboxIp.ReadOnly = false;
            }
        }

        /// <summary>
        /// closed en disposed de formstartgame.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void pictureBoxStartmenuTerug_Click_1(object sender, EventArgs e)
        {
            this.pictureBoxTerug.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("TerugButtonBlauw2D");
            await Task.Delay(300);
            this.pictureBoxTerug.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("TerugButtonBlauw");
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textboxNaam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// zet alle ingevoerde data in variabelen. en called de startgame methode van de gekozen gamemode. 
        /// vervolgens word de form geclosed en gedisposed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void pictureBoxStartmenuStart_Click_1(object sender, EventArgs e)
        {
            this.pictureBoxStart.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("StartButtonGroen2D");
            await Task.Delay(300);
            this.pictureBoxStart.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("StartButtonGroen");
            Geluid.Player.Stop();
            Geluid.Player.Dispose();
            GC.Collect();
            int h, w;
            if (comboGametype.Text != "Join Multiplayer") {
                switch (comboSpelgrootte.Text) {
                    //vooet grote van het speelveld in
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
            //voert naam in en called stargame
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

                    BackgroundWorker worker = new BackgroundWorker();
                    worker.DoWork += delegate (object o, DoWorkEventArgs args) {
                        args.Result = ManagerServer.Server(port);
                    };
                    worker.RunWorkerCompleted += delegate (object o, RunWorkerCompletedEventArgs args) {
                        if ((bool) args.Result) {
                            GameMultiplayerOnline.Start(h, w, naams, true);
                            this.Close();
                            this.Dispose();
                        }
                    };
                    worker.RunWorkerAsync();
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
                    //Errorbox wordt weergegeven doe Client method
                    break;
                case "Kies spelmodus":
                    MessageBox.Show("Voer een spelmodus in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

            }
        }

        private void textboxIp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
