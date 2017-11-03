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
        public static string path1 = "SingleplayerScores.txt"; //@"C:\Users\Me\Documents\GitHub\Memory\
        public static string path2 = "LocalMultiplayerScores.txt";

        /// <summary>
        /// Verkrijg alle highscores in een lijst
        /// </summary>
        /// <param name="path">De path van de highscores file</param>
        /// <returns>De highscores</returns>
        public static List<Object[]> GetHighscores(string path)
        {
            //Als de file niet bestaat return een lege lijst
            if (!File.Exists(path)) return new List<Object[]>();

            //Lees het bestand
            string lines = File.ReadAllText(path);

            //Convert lines naar list
            return new List<object[]>(Utils.StringToArray(lines) as object[][]);
        }

        /// <summary>
        /// Sla de highscores op in een file
        /// </summary>
        /// <param name="path">De path van de highscores file</param>
        /// <param name="highscores">De highscores</param>
        public static void SaveHighscores(string path, List<Object[]> highscores)
        {
            object[][] highscores_array = highscores.ToArray();
            File.WriteAllText(path, Utils.ArrayToString(highscores_array));
        }

        /// <summary>
        /// Sla de huidige game op in de highscores
        /// </summary>
        public static void UpdateHighscores()
        {
            //Verkrijg alle highscores
            List<object[]> highscores = GetHighscores(BaseGame.Gamemode == 0 ? path1 : path2);

            //Voeg nieuw highscore entry toe in highscores
            object[] entry = NieuwHighscore();
            highscores.Add(entry);

            //Sorteer highscores
            highscores.Sort(delegate (object[] a, object[] b)
            {
                //Vergelijk score
                int scorecomp = ((int)b[1]).CompareTo((int)a[1]);
                if (scorecomp != 0) return scorecomp;

                //Vergelijk zetten
                int zettencomp = ((int)a[2]).CompareTo((int)b[2]);
                if (zettencomp != 0) return zettencomp;

                //Vergelijk tijd
                return ((int)a[3]).CompareTo((int)b[2]);
            });

            //Maak lijst niet te lang
            int maxlength = BaseGame.Gamemode == 0 ? 20 : 10;
            while (highscores.Count > 10) highscores.RemoveAt(highscores.Count - 1);

            //Convert naar lines
            SaveHighscores(BaseGame.Gamemode == 0 ? path1 : path2, highscores);
        }


        /// <summary>
        /// Maakt een nieuw item voor in de tabel
        /// </summary>
        /// <returns>Het item als object array</returns>
        public static object[] NieuwHighscore()
        {
            if (BaseGame.Gamemode == 0)
            {
                return new object[] { BaseGame.Naam1, BaseGame.Score1, BaseGame.Zetten1, BaseGame.Tijdtotaal };
            }
            else
            {
                //Als speler 1 gewonnen heeft
                if(BaseGame.Score1 > BaseGame.Score2 || (BaseGame.Score1 == BaseGame.Score2 && BaseGame.Zetten1 <= BaseGame.Zetten2))
                {
                    return new object[] { BaseGame.Naam1, BaseGame.Score1, BaseGame.Zetten1, BaseGame.Tijdtotaal, BaseGame.Naam2, BaseGame.Score2, BaseGame.Zetten2 };
                }
                else
                {
                    return new object[] { BaseGame.Naam2, BaseGame.Score2, BaseGame.Zetten2, BaseGame.Tijdtotaal, BaseGame.Naam1, BaseGame.Score1, BaseGame.Zetten1 };
                }
            }
        }

        public static DataTable GetTable(bool multi)
        {
            //Maak datatable
            DataTable table = new DataTable();
            table.Columns.Add(" ", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Score", typeof(int));
            table.Columns.Add("Zetten", typeof(int));
            table.Columns.Add("Tijd (sec)", typeof(int));

            //Vul datatable
            List<object[]> highscores = GetHighscores(multi ? path2 : path1);
            for(int i = 0; i < highscores.Count; i++)
            {
                object[] highscore = highscores[i];
                if(highscore.Length == 4)
                {
                    table.Rows.Add((i + 1) + ".", highscore[0], highscore[1], highscore[2], highscore[3]);
                }
                else
                {
                    table.Rows.Add((i + 1) + ".", highscore[0], highscore[1], highscore[2], highscore[3]);
                    table.Rows.Add(" ", highscore[4], highscore[5], highscore[6], null);
                }
            }
            for(int i = 0; i < (multi == false ? 20 - highscores.Count : (10 - highscores.Count) * 2 ); i++) 
            {
                table.Rows.Add();  
            }
            return table;
        }
    }
}

