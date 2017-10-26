using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace Memory
{
    class ManagerHighscores
    {
        public static string path1 = "TextFileSingleplayerScores.txt"; //@"C:\Users\Me\Documents\GitHub\Memory\
        public static string path2 = "TextFileLocalMultiplayerScores.txt";
        public static int SaveLengthSingelplayer = 20;
        public static int SaveLengthMultiplayer = 10;

        //maak bestand als het nog niet bestaat
        public static void CheckHighscoreFiles()
        {
            if (!File.Exists(path1))
            {
                File.Create(path1).Close();
            }
            if (!File.Exists(path2))
            {
                File.Create(path2).Close();
            }
        }

        //Gegevens Highscores opslaan 
        public static void SingleplayerSave()
        {
            //toevoegen en lege lijnen verwijderen:
            string resultaat = BaseGame.Naam1 + "|" + Convert.ToString(BaseGame.Score1) + "|" + Convert.ToString(BaseGame.Zetten1) + "|" + Convert.ToString(BaseGame.Tijdtotaal);
            File.WriteAllLines(path1, File.ReadAllLines(path1).Where(l => !string.IsNullOrWhiteSpace(l)));
            File.AppendAllText(path1, resultaat);
            File.AppendAllText(path1, Environment.NewLine);

            //bubbelsorting:
            string[] lines = File.ReadAllLines(ManagerHighscores.path1);
            string temp = "";
            for (int write = 0; write < lines.Length; write++)
            {
                for (int sort = 0; sort < lines.Length - 1; sort++)
                {
                    bool hoger = false;
                    string[] line = lines[sort].Split('|');
                    int max = Convert.ToInt32(line[1]);
                    string[] line2 = lines[sort + 1].Split('|');
                    int max2 = Convert.ToInt32(line2[1]);
                    //kijk voor hogere score
                    if (max == max2)
                    {
                        //kijk voor lagere zetten
                        int zet = Convert.ToInt32(line[2]);
                        int zet2 = Convert.ToInt32(line2[2]);
                        if (zet == zet2)
                        {
                            //kijk voor kortere tijd
                            int time = Convert.ToInt32(line[3]);
                            int time2 = Convert.ToInt32(line2[3]);
                            if (time > time2)
                            {
                                hoger = true;
                            }
                        }
                        else if (zet > zet2)
                        {
                            hoger = true;
                        }
                    }
                    else if (max < max2)
                    {
                        hoger = true;
                    }
                    //als een van de if'en geld voer verplaating uit
                    if (hoger == true)
                    {
                        temp = lines[sort + 1];
                        lines[sort + 1] = lines[sort];
                        lines[sort] = temp;
                    }
                }
            }
            //haal overbodige info weg
            if (SaveLengthSingelplayer < File.ReadLines(path1).Count())
            {
                string[] newlines = new string[SaveLengthSingelplayer];
                Array.Copy(lines, 0, newlines, 0, SaveLengthSingelplayer);
                File.WriteAllLines(path1, newlines);
            }
            else
            {
                File.WriteAllLines(path1, lines);
            }
        }

        public static void MultiplayerLocalSave()
        {
            //kijken wie het beste heeft gespeeld:
            bool Player1won = false;
            if (BaseGame.Score1 == BaseGame.Score2)
            {
                if (BaseGame.Zetten1 <= BaseGame.Zetten2)
                {
                    Player1won = true;
                }
            }
            else if (BaseGame.Score1 > BaseGame.Score2)
            {
                Player1won = true;
            }
             
            //toevoegen en lege lijnen verwijderen:
            string resultaat = "";
            if (Player1won == true)
            {
                resultaat = BaseGame.Naam1 + "|" + Convert.ToString(BaseGame.Score1) + "|" + Convert.ToString(BaseGame.Zetten1) + "|" + Convert.ToString(BaseGame.Tijdtotaal)
                + "|" + BaseGame.Naam2 + "|" + Convert.ToString(BaseGame.Score2) + "|" + Convert.ToString(BaseGame.Zetten2);
            }
            else
            {
                resultaat = BaseGame.Naam2 + "|" + Convert.ToString(BaseGame.Score2) + "|" + Convert.ToString(BaseGame.Zetten2) + "|" + Convert.ToString(BaseGame.Tijdtotaal)
                + "|" + BaseGame.Naam1 + "|" + Convert.ToString(BaseGame.Score1) + "|" + Convert.ToString(BaseGame.Zetten1);
            }
            File.WriteAllLines(path2, File.ReadAllLines(path2).Where(l => !string.IsNullOrWhiteSpace(l)));
            File.AppendAllText(path2, resultaat);
            File.AppendAllText(path2, Environment.NewLine);

            //bubbelsorting:
            string[] lines = File.ReadAllLines(path2);
            string temp = "";
            for (int write = 0; write < lines.Length; write++)
            {
                for (int sort = 0; sort < lines.Length - 1; sort++)
                {
                    bool hoger = false;
                    string[] line = lines[sort].Split('|');
                    int score = Convert.ToInt32(line[1]);
                    string[] line2 = lines[sort + 1].Split('|');
                    int score2 = Convert.ToInt32(line2[1]);
                    if (score == score2)
                    {
                        int zet = Convert.ToInt32(line[2]);
                        int zet2 = Convert.ToInt32(line2[2]);
                        if (zet == zet2)
                        {
                            int time = Convert.ToInt32(line[3]);
                            int time2 = Convert.ToInt32(line2[3]);
                            if (time > time2)
                            {
                                hoger = true;
                            }
                        }
                        else if (zet > zet2)
                        {
                            hoger = true;
                        }
                    }
                    else if (score < score2)
                    {
                        hoger = true;
                    }
                    if (hoger == true)
                    {
                        temp = lines[sort + 1];
                        lines[sort + 1] = lines[sort];
                        lines[sort] = temp;
                    }
                }
            }
            //haal overbodige info weg
            if (SaveLengthMultiplayer < File.ReadLines(path2).Count())
            {
                string[] newlines = new string[SaveLengthMultiplayer];
                Array.Copy(lines, 0, newlines, 0, SaveLengthMultiplayer);
                File.WriteAllLines(path2, newlines);
            }
            else
            {
                File.WriteAllLines(path2, lines);
            }
        }

        //load tabbelen FormHighscores
        static public DataTable GetTableSingelplayer()
        {
            //columns
            DataTable table = new DataTable();
            table.Columns.Add(" ", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Score", typeof(int));
            table.Columns.Add("Zetten", typeof(int));
            table.Columns.Add("Tijd (sec)", typeof(int));
            //rows / inhoud
            string[] lines = File.ReadAllLines(path1);
            for (int i = 0; i < File.ReadAllLines(path1).Count(); i++)
            {
                string[] inhoud = lines[i].Split('|');
                table.Rows.Add((i + 1) + ".", inhoud[0], inhoud[1], inhoud[2], inhoud[3]);
            }
            //voeg lege rows toe indien nodig
            for (int i = 0; i < SaveLengthSingelplayer - lines.Length; i++) // dit zou anders kunnen gedaan worden!!!!!!!
            {
                table.Rows.Add();
            }
            return table;
        }

        static public DataTable GetTableMultiplayer()
        {
            //columns
            DataTable table = new DataTable();
            table.Columns.Add(" ", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Score", typeof(int));
            table.Columns.Add("Zetten", typeof(int));
            table.Columns.Add("Tijd (sec)", typeof(int));
            //rows / inhoud
            string[] lines = File.ReadAllLines(path2);
            for (int i = 0; i < File.ReadAllLines(path2).Count(); i++)
            {
                string[] inhoud = lines[i].Split('|');
                table.Rows.Add((i + 1) + ".", inhoud[0], inhoud[1], inhoud[2], inhoud[3]);
                table.Rows.Add(" ", inhoud[4], inhoud[5], inhoud[6], null);
            }
            //voeg lege rows toe indien nodig
            for (int i = 0; i < (SaveLengthMultiplayer - lines.Length) * 2; i++) // dit zou anders kunnen gedaan worden!!!!!!!
            {
                table.Rows.Add();
            }
            return table;
        }

    }
}

