using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    class ManagerSavegames
    {
        public static string[] Savedata = new string[25];
        public static string[] Loaddata;
        private static string Bestandslocatie = "";


        

        public static void Savegame()
        {
            //vooer savedata in
            Savedata[0] = Convert.ToString(BaseGame.Gamemode);
            Savedata[1] = Convert.ToString(BaseGame.Gamestate);
            Savedata[2] = Utils.ArrayToString(BaseGame.Speelveld_types);
            Savedata[3] = Utils.ArrayToString(BaseGame.Speelveld_omgedraaid);
            Savedata[4] = Convert.ToString(BaseGame.Height);
            Savedata[5] = Convert.ToString(BaseGame.Width);
            Savedata[6] = Convert.ToString(BaseGame.Zetten1);
            Savedata[7] = Convert.ToString(BaseGame.Zetten2);
            Savedata[8] = Convert.ToString(BaseGame.Score1);
            Savedata[9] = Convert.ToString(BaseGame.Score2);
            Savedata[10] = Convert.ToString(BaseGame.Kaart1x);
            Savedata[11] = Convert.ToString(BaseGame.Kaart1y);
            Savedata[12] = Convert.ToString(BaseGame.Kaart2x);
            Savedata[13] = Convert.ToString(BaseGame.Kaart2y);
            Savedata[14] = Convert.ToString(BaseGame.Kaartcounter);
            Savedata[15] = Convert.ToString(BaseGame.Naam1);
            Savedata[16] = Convert.ToString(BaseGame.Naam2);
            Savedata[17] = Convert.ToString(BaseGame.SpelerAanBeurt);
            Savedata[18] = Convert.ToString(BaseGame.Tijdbeurt);
            Savedata[19] = Convert.ToString(BaseGame.Tijdtotaal);
            Savedata[20] = Convert.ToString(BaseGame.Terugdraai);
            Savedata[21] = Convert.ToString("");
            Savedata[22] = Convert.ToString("");
            Savedata[23] = Convert.ToString("");
            Savedata[24] = Convert.ToString("");

            string WriteData = Utils.ArrayToString(Savedata); //convert array naar 1 string
            WriteData = Utils.Encrypt(WriteData, "dat boi harro");


            //maak bestands path met save file dialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "save files (*.sav)|*.sav|All files (*.*)|*.*";
            string sfdname = sfd.FileName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Bestandslocatie = Path.GetFullPath(sfd.FileName);
            }

            if (Bestandslocatie == null || Bestandslocatie == "") //voorkomt lege bestandslocatie error
            {
                return;
            }



            System.IO.File.WriteAllText(Bestandslocatie, WriteData); //write

          
        }

        public static void Loadgame()
        {
            //get bestands path met open file dialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "save files (*.sav)|*.sav|All files (*.*)|*.*";
            string ofdname = ofd.FileName;
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                Bestandslocatie = Path.GetFullPath(ofd.FileName);
            }

            if (Bestandslocatie == null || Bestandslocatie == "") //voorkomt lege bestandslocatie error
            {
                return;
            }
            

            try
            {
                string Readdata = System.IO.File.ReadAllText(Bestandslocatie);  //read
                Readdata = Utils.Decrypt(Readdata, "dat boi harro");
                Loaddata = Utils.StringToArray(Readdata) as string[];  //convert naar array
            }
            catch
            {
                MessageBox.Show("error");
            }
            switch(Convert.ToInt32(Loaddata[0]))
            {
                case 0:  //singleplayer
                    GameSingleplayer.Start(Convert.ToInt32(Loaddata[4]), Convert.ToInt32(Loaddata[5]),Loaddata[15]);
                    Initiate();
                    break;
                case 1:  //multiplayer
                    GameMultiplayerLocal.Start(Convert.ToInt32(Loaddata[4]), Convert.ToInt32(Loaddata[5]), Loaddata[15], Loaddata[16]);
                    Initiate();
                    break;
            }
           

        }

        private static void Initiate()
        {
            //laad alle variabelen
            BaseGame.Gamemode = Convert.ToInt32(Loaddata[0]);
            BaseGame.Gamestate = Convert.ToInt32(Loaddata[1]);
            BaseGame.Speelveld_types = Utils.StringToArray(Loaddata[2]) as int[,];
            BaseGame.Speelveld_omgedraaid = Utils.StringToArray(Loaddata[3]) as bool[,];
            BaseGame.Height = Convert.ToInt32(Loaddata[4]);
            BaseGame.Width = Convert.ToInt32(Loaddata[5]);
            BaseGame.Zetten1 = Convert.ToInt32(Loaddata[6]);
            BaseGame.Zetten2 = Convert.ToInt32(Loaddata[7]);
            BaseGame.Score1 = Convert.ToInt32(Loaddata[8]);
            BaseGame.Score2 = Convert.ToInt32(Loaddata[9]);
            BaseGame.Kaart1x= Convert.ToInt32(Loaddata[10]);
            BaseGame.Kaart1y = Convert.ToInt32(Loaddata[11]);
            BaseGame.Kaart2x = Convert.ToInt32(Loaddata[12]);
            BaseGame.Kaart2y = Convert.ToInt32(Loaddata[13]);
            BaseGame.Kaartcounter = Convert.ToInt32(Loaddata[14]);
            BaseGame.Naam1 = Convert.ToString(Loaddata[15]);
            BaseGame.Naam2 = Convert.ToString(Loaddata[16]);
            BaseGame.SpelerAanBeurt = Convert.ToInt32(Loaddata[17]);
            BaseGame.Tijdbeurt = Convert.ToInt32(Loaddata[18]);
            BaseGame.Tijdtotaal = Convert.ToInt32(Loaddata[19]);
            BaseGame.Terugdraai = Convert.ToBoolean(Loaddata[20]);

            BaseGame.Render(); // rendered opgegeven waarden

            //draait omgedraaide kaarten om
            for (int h= 0; h < BaseGame.Height; h++)
            {
                for (int w =0; w < BaseGame.Width; w++)
                {
                    BaseGame.ZetOmgedraaid(w, h, BaseGame.Speelveld_omgedraaid[w, h]);
                }
            }

            //draait 2 ongelijke kaarten terug als die geload zijn.
            if (BaseGame.Speelveld_types[BaseGame.Kaart1x, BaseGame.Kaart1y] != BaseGame.Speelveld_types[BaseGame.Kaart2x, BaseGame.Kaart2y]) 
            {
                BaseGame.DraaiKaartenTerug();
            }
            

        }

        public static void SaveEnEnd()
        {
            Savegame();
            Bestandslocatie = "";
            BaseGame.Exitgame();
        }
        
            

        


    }
}
