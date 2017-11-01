using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;


namespace Memory
{
    class Geluid
    {
        public static Stream str = (Stream)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "AchtergrondMuziek");
        public static SoundPlayer Player = new SoundPlayer(str);
        public static bool Volume;

        /// <summary>
        /// speelt de achtergrond muziek van het geselecteerde thema af
        /// </summary>
        public static void AchtergrondMuziek()
        {
            if (Volume == true)
            {
                try
                {
                    str = (Stream)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "AchtergrondMuziek");
                    Player = new SoundPlayer(str);
                    Player.PlayLooping();
                }
                catch
                {
                    Console.WriteLine("sound_error");
                }
            }
        }
        /// <summary>
        /// speelt het geluid van een omdraaiende kaart af
        /// </summary>
        public static void KaartKlik()
        {
            if (Volume == true)
            {
                try
                {
                    Player.Dispose();
                    str = (Stream)Properties.Resources.ResourceManager.GetObject("KaartFlick");
                    Player = new SoundPlayer(str);
                    Player.Play();
                    if (BaseGame.Kaartcounter == 2)
                    {
                        Player.Dispose();
                    }

                }
                catch
                {
                    Console.WriteLine("sound_error");
                }
            }
        }
        /// <summary>
        /// speelt het endgame geluid af
        /// </summary>
        public static void GameOver()
        {
            if (Volume == true)
            {
                try
                {
                    str = (Stream)Properties.Resources.ResourceManager.GetObject("GameOver");
                    Player = new SoundPlayer(str);
                    Player.Play();

                }
                catch
                {
                    Console.WriteLine("sound_error");
                }
            }
        }
        /// <summary>
        /// speelt het geluid af voor 2 kaarten die gelijk zijn.
        /// </summary>
        public static void KaartGelijk()
        {
            if (Volume == true)
            {
                try
                {
                    str = (Stream)Properties.Resources.ResourceManager.GetObject("KaartGelijk");
                    Player = new SoundPlayer(str);
                    Player.Play();

                }
                catch
                {
                    Console.WriteLine("sound_error");
                }
            }
        }





    }
}
