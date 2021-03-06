﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class GameSingleplayer
    {
        public static void Start(int Hoogte, int Breedte, string Naam) {
            BaseGame.Gamemode = 0;
            BaseGame.InitSpeelveld(Hoogte, Breedte);
            BaseGame.InitForm();
            BaseGame.FormSpeelveld.Label_Score_Speler_2.Visible = false;
            BaseGame.FormSpeelveld.Label_Score_Speler_2.Visible = false;
            BaseGame.FormSpeelveld.Label_Zetten_Speler_2.Visible = false;
            BaseGame.FormSpeelveld.Label_Zetten_Speler_2.Visible = false;
            BaseGame.FormSpeelveld.Textbox_Score_Speler_2.Visible = false;
            BaseGame.FormSpeelveld.Textbox_Zetten_Speler_2.Visible = false;
            BaseGame.FormSpeelveld.Label_Beurt.Visible = false;
            BaseGame.SpelerAanBeurt = 1;
            BaseGame.Gamestate = 1;
            BaseGame.Naam1 = Naam;
            BaseGame.FormSpeelveld.Label_Score_Speler_1.Text = Naam + " : ";
            BaseGame.Timer();
            BaseGame.Render();
        }

        public static void VolgendeBeurt() {

        }

        public static async void End() {
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
