using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class GameMultiplayerLocal
    {
        public static void Start(int Hoogte, int Breedte, string Naam1, string Naam2)
        {
            BaseGame.Gamemode = 1;
            BaseGame.InitSpeelveld(Hoogte, Breedte);
            BaseGame.InitForm();
            BaseGame.SpelerAanBeurt = Utils.rand.Next(1, 3);
            BaseGame.Gamestate = 1;
            BaseGame.Naam1 = Naam1;
            BaseGame.Naam2 = Naam2;
            BaseGame.FormSpeelveld.Label_Score_Speler_1.Text = Naam1 + " : ";
            BaseGame.FormSpeelveld.Label_Score_Speler_2.Text = Naam2 + " : ";
            BaseGame.Timer();
            BaseGame.Render();
        }

        public static void VolgendeBeurt()
        {
            //Als de kaarten niet gelijk zijn
            if (BaseGame.Speelveld_types[BaseGame.Kaart1x, BaseGame.Kaart1y] != BaseGame.Speelveld_types[BaseGame.Kaart2x, BaseGame.Kaart2y])
            {
                //Coole syntax om speler aan beurt te switchen tussen 1 en 2
                BaseGame.SpelerAanBeurt = BaseGame.SpelerAanBeurt == 1 ? 2 : 1;
            }
        }

        public static async void End()
        {
            await Task.Delay(2000);
            Exit();
            
        }
        public static void Exit()
        {
            BaseGame.Gamestate = 2;
            BaseGame.FormSpeelveld.Close();
            BaseGame.FormSpeelveld.Dispose();
            GC.Collect();
            FormEndgame endgame = new FormEndgame();
            endgame.ShowDialog();

        }
    }
}
