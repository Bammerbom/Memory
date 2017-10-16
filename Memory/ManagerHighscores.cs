using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Memory
{
    class ManagerHighscores
    {
        public static string path1 = "TextFileSingleplayerScores.txt"; //@"C:\Users\Me\Documents\GitHub\Memory\
        public static string path2 = "TextFileLocalMultiplayerScores.txt";
        public static int SaveLengthSingelplayer = 10;
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

        public static void SingleplayerSave()
        {
        //toevoegen en lege lijnen verwijderen:
            string resultaat = BaseGame.Naam1 + "|" + Convert.ToString(BaseGame.Score1) + "|" + Convert.ToString(BaseGame.Zetten1) + "|" + Convert.ToString(BaseGame.Tijdtotaal);
            File.WriteAllLines(path1, File.ReadAllLines(path1).Where(l => !string.IsNullOrWhiteSpace(l))); 
            File.AppendAllText(path1, resultaat);
            File.AppendAllText(path1, Environment.NewLine);

        //bubbelsorting:
            string[] lines = File.ReadAllLines(ManagerHighscores.path1);
            string temp ="";
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
            string[] newlines = new string[ManagerHighscores.SaveLengthSingelplayer]; 
            Array.Copy(lines, 0, newlines, 0, ManagerHighscores.SaveLengthSingelplayer);
        //save
            File.WriteAllLines(path1, newlines);  
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
            string[] lines = File.ReadAllLines(ManagerHighscores.path2);
            string temp = "";
            for (int write = 0; write < lines.Length; write++)
            {
                for (int sort = 0; sort < lines.Length - 1; sort++)
                {
                    string[] line = lines[sort].Split('|');
                    int[] score1 = new int[] {Convert.ToInt32(line[1]), Convert.ToInt32(line[5])};
                    int max = score1.Max();

                    line = lines[sort + 1].Split('|');
                    int[] score2 = new int[] {Convert.ToInt32(line[1]), Convert.ToInt32(line[5])};
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
            string[] newlines = new string[ManagerHighscores.SaveLengthMultiplayer];
            Array.Copy(lines, 0, newlines, 0, ManagerHighscores.SaveLengthMultiplayer);
        //save
            File.WriteAllLines(path2, newlines);
        }
    }

        //int lineCount = File.ReadLines(GameResultaten.path1).Count();
        //while (lineCount > 10)
        //{

        //    // is voor checten of de file nu dus wel 10 regels is
        //    lineCount = File.ReadLines(GameResultaten.path1).Count();
        //}

        //regel met resultaat toevoegen
        //string resultaat = BaseGame.Naam1 + "|" + Convert.ToString(BaseGame.Score1) + "|" + Convert.ToString(BaseGame.Zetten1) + "|" + Convert.ToString(BaseGame.Tijdtotaal);

        //using (StreamWriter writer = new StreamWriter(GameResultaten.path1))
        //{
        //    writer.WriteLine(resultaat);
        //}

        //string[] lines = File.ReadAllLines(GameResultaten.path1);
        //int LengthLines = lines.Length;
        //while (LengthLines > 10 )
        //{
        //    //vinden van regel met klijste score:
        //    int[] scores = new int[LengthLines];
        //    int i = 0;
        //    foreach (string line in lines)
        //    {
        //        string[] inhoud = line.Split('|');
        //        scores[i] = Convert.ToInt32(inhoud[1]);
        //        i++;
        //    }
        //    int minIndexScores = Array.IndexOf(scores, scores.Min());

        //    minIndexScores;
        //    LengthLines = lines.Length;
        //}
        //File.WriteAllLines(GameResultaten.path1, lines);
        //while (File.ReadLines(GameResultaten.path1).Count() > GameResultaten.SaveCountSingelplayer)
        //{
        //    lines[File.ReadLines(GameResultaten.path1).Count() - 1] = "";
        //    File.WriteAllLines(path1, File.ReadAllLines(path1).Where(l => !string.IsNullOrWhiteSpace(l)));
        //    lines = File.ReadAllLines(GameResultaten.path1);
        //}
        //for (int i = lineCount; i >= 0; i--)
        //        {
        //        if (lines[i] != null)
        //    {
        //        string[] line = lines[i].Split('|');
        //        int score = Convert.ToInt32(line[1]);
        //        if (score < score_res)
        //        {
        //            if (i != 9)
        //            {
        //                lines[i + 1] = lines[i];
        //            }
        //            lines[i] = resultaat;
        //        }
        //    }
        //    else if (lines[i] == null && lines[i - 1] != null)
        //    {
        //        string[] line = lines[i - 1].Split('|');
        //        int score = Convert.ToInt32(line[1]);

        //        if (score < score_res)
        //        {
        //            lines[i] = lines[i - 1];
        //            lines[i - 1] = resultaat;
        //        }
        //        else
        //        {
        //            lines[i] = resultaat;
        //        }
        //    }
        //    else if (lines[i] == null && i == 0)
        //    {
        //        lines[i] = resultaat;
        //    }

        //}
        //File.WriteAllLines(GameResultaten.path1, lines);
        //int score_res = BaseGame.Score1;      //string[] resultaat_gegevens = resultaat.Split('|');//int score_res = Convert.ToInt32(resultaat_gegevens[1]);
        //int lineCount = File.ReadLines(GameResultaten.path1).Count();
}
