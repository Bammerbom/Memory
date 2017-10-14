using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Memory
{
    class GameResultaten
    {

        public static string path1 = "TextFileSingleplayerScores.txt"; //@"C:\Users\Me\Documents\GitHub\Memory\
        public static string path2 = "TextFileLocalMultiplayerScores.txt";
        public static int SaveCountSingelplayer = 10;

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
            //if (lineCount < GameResultaten.ShowCountSingelplayer)
            //{
                File.WriteAllLines(path1, File.ReadAllLines(path1).Where(l => !string.IsNullOrWhiteSpace(l))); // l ????
                File.AppendAllText(path1, resultaat);
                File.AppendAllText(path1, Environment.NewLine);
            //}

        //gegevens klaar zetten voor bubbelsorting:
            //int lineCount = File.ReadLines(GameResultaten.path1).Count();
            string[] lines = File.ReadAllLines(GameResultaten.path1);
            //int score_res = BaseGame.Score1;      //string[] resultaat_gegevens = resultaat.Split('|');//int score_res = Convert.ToInt32(resultaat_gegevens[1]);

        //bubbelsorting:
            string temp ="";
            for (int write = 0; write < lines.Length; write++)
            {
                for (int sort = 0; sort < lines.Length - 1; sort++)
                {
                    string[] line = lines[sort].Split('|');
                    int score1 = Convert.ToInt32(line[1]);
                    line = lines[sort + 1].Split('|');
                    int score2 = Convert.ToInt32(line[1]);
                    if (score1 > score2)
                    {
                        temp = lines[sort + 1];
                        lines[sort + 1] = lines[sort];
                        lines[sort] = temp;
                    }
                }
            }
            File.WriteAllLines(path1, lines);
        //haal overbodige info weg
            while (File.ReadLines(GameResultaten.path1).Count() > GameResultaten.SaveCountSingelplayer)
            {
                lines[File.ReadLines(GameResultaten.path1).Count() - 1] = "";
                File.WriteAllLines(path1, File.ReadAllLines(path1).Where(l => !string.IsNullOrWhiteSpace(l)));
                lines = File.ReadAllLines(GameResultaten.path1);
            }




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
        }

        public static void MultiplayerLocalSave()
        {

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
    }
}
