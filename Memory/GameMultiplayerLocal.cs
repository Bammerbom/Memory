using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class GameMultiplayerLocal
    {
        /// <summary>
        /// Deze method start de local multiplayer game
        /// </summary>
        /// <param name="Hoogte">Hoogte van het speelveld</param>
        /// <param name="Breedte">Breedte van het speelveld</param>
        /// <param name="Naam1">De naam van speler 1</param>
        /// <param name="Naam2">De naam van speler 2</param>
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

        /// <summary>
        /// Deze method maakt de game klaar voor de volgende beurt
        /// </summary>
        public static void VolgendeBeurt()
        {
            //Als de kaarten niet gelijk zijn
            if (BaseGame.Speelveld_types[BaseGame.Kaart1x, BaseGame.Kaart1y] != BaseGame.Speelveld_types[BaseGame.Kaart2x, BaseGame.Kaart2y] ||BaseGame.BeurtVerlopen == true)
            {
                //Coole syntax om speler aan beurt te switchen tussen 1 en 2
                BaseGame.SpelerAanBeurt = BaseGame.SpelerAanBeurt == 1 ? 2 : 1;
                BaseGame.BeurtVerlopen = false;
             
            }
            
            

            
        }
        
        /// <summary>
        /// Deze method zorgt ervoor dat de game exit. 
        /// Hierop zit een delay zodat de speler kan zien dat hij/zij gewonnen heeft.
        /// </summary>
        public static async void End()
        {
            await Task.Delay(2000);
            Exit();
            
        }

        /// <summary>
        /// Deze method sluit het spel af en opent de end game form
        /// </summary>
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
