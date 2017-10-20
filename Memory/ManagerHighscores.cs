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
                    string[] line = lines[sort].Split('|');
                    int score1 = Convert.ToInt32(line[1]);
                    line = lines[sort + 1].Split('|');
                    int score2 = Convert.ToInt32(line[1]);
                    if (score1 < score2)
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
            //toevoegen en lege lijnen verwijderen:
            string resultaat = BaseGame.Naam1 + "|" + Convert.ToString(BaseGame.Score1) + "|" + Convert.ToString(BaseGame.Zetten1) + "|" + Convert.ToString(BaseGame.Tijdtotaal)
                + "|" + BaseGame.Naam2 + "|" + BaseGame.Score2 + "|" + BaseGame.Zetten2;
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
                    string[] line = lines[sort].Split('|');
                    int[] score1 = new int[] { Convert.ToInt32(line[1]), Convert.ToInt32(line[5]) };
                    int max = score1.Max();

                    line = lines[sort + 1].Split('|');
                    int[] score2 = new int[] { Convert.ToInt32(line[1]), Convert.ToInt32(line[5]) };
                    int max2 = score2.Max();

                    if (max < max2)
                    {
                        temp = lines[sort + 1];
                        lines[sort + 1] = lines[sort];
                        lines[sort] = temp;
                    }
                }
            }
            //haal overbodige info weg
            if (SaveLengthMultiplayer < File.ReadLines(path2).Count()) {
                string[] newlines = new string[SaveLengthMultiplayer];
                Array.Copy(lines, 0, newlines, 0, SaveLengthMultiplayer);
                File.WriteAllLines(path2, newlines);
            } else {
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
                //speler 1 won
                if (Convert.ToInt32(inhoud[1]) >= Convert.ToInt32(inhoud[5]))
                {
                    table.Rows.Add((i + 1) + ".", inhoud[0], inhoud[1], inhoud[2], inhoud[3]);
                    table.Rows.Add("", inhoud[4], inhoud[5], inhoud[6], null);
                }
                //speler 2 won
                else
                {
                    table.Rows.Add((i + 1) + ".", inhoud[4], inhoud[5], inhoud[6], inhoud[3]);
                    table.Rows.Add(" ", inhoud[0], inhoud[1], inhoud[2], null);
                }
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

