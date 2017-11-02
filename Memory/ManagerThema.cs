using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class ManagerThema
    {

        public static int Themanummer ;
        public static string Themaprefix;

        /// <summary>
        /// deze thema verandert de themaperfix en nummer die gebruikt worden bij het loaden van thema's in andere forms.
        /// </summary>
        /// <param name="Thema"></param>
        public static void VeranderThema(string Thema)
        {
            
            switch (Thema)
            {
                case "Default":
                    Themanummer = 0;
                    Themaprefix = "Thema0";
                    break;

                case "Disney":
                    Themanummer = 2;
                    Themaprefix = "Thema2";
                    break;

                case "StarWars":
                    Themanummer = 1;
                    Themaprefix = "Thema1";
                    break;

                
            }
        }

    }
}
