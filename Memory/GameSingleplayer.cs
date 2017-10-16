using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class GameSingleplayer
    {
        public static void Start(int Hoogte, int Breedte, string Naam) {
            BaseGame.InitSpeelveld(Hoogte, Breedte);
            BaseGame.InitForm();
            BaseGame.FormSpeelveld.Textbox_Score_Speler_2.Visible = false;
            BaseGame.FormSpeelveld.Label_Score_Speler_2.Visible = false;
            BaseGame.FormSpeelveld.Label_Zetten_Speler_2.Visible = false;
            BaseGame.FormSpeelveld.Textbox_Zetten_Speler_2.Visible = false;
            BaseGame.FormSpeelveld.TextBox_Beurt.Visible = false;
            BaseGame.SpelerAanBeurt = 1;
            BaseGame.Gamestate = 1;
            BaseGame.Naam1 = Naam;
            BaseGame.FormSpeelveld.Label_Score_Speler_1.Text = Naam + " : ";
            BaseGame.Timer();

        }

        public static async void End() {
            
            BaseGame.Gamestate = 2;
            await Task.Delay(2000);
            BaseGame.FormSpeelveld.Close();
            FormEndgame endgame = new FormEndgame();
            endgame.Show();
        }
    }
}
