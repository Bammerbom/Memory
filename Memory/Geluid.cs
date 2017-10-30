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
        public static SoundPlayer player = new SoundPlayer(str);
        public static bool Volume;


        public static void AchtergrondMuziek()
        {
            if (Volume == true)
            {
                try
                {
                    str = (Stream)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "AchtergrondMuziek");
                    player = new SoundPlayer(str);
                    player.PlayLooping();
                }
                catch
                {
                    Console.WriteLine("sound_error");
                }
            }
        }

        public static void KaartKlik()
        {
            if (Volume == true)
            {
                try
                {
                    str = (Stream)Properties.Resources.ResourceManager.GetObject("KaartFlick");
                    player = new SoundPlayer(str);
                    player.Play();
                    if (BaseGame.Kaartcounter == 2)
                    {
                        player.Dispose();
                    }

                }
                catch
                {
                    Console.WriteLine("sound_error");
                }
            }
        }

        public static void GameOver()
        {
            if (Volume == true)
            {
                try
                {
                    str = (Stream)Properties.Resources.ResourceManager.GetObject("GameOver");
                    player = new SoundPlayer(str);
                    player.Play();

                }
                catch
                {
                    Console.WriteLine("sound_error");
                }
            }
        }

        public static void KaartGelijk()
        {
            if (Volume == true)
            {
                try
                {
                    str = (Stream)Properties.Resources.ResourceManager.GetObject("KaartGelijk");
                    player = new SoundPlayer(str);
                    player.Play();

                }
                catch
                {
                    Console.WriteLine("sound_error");
                }
            }
        }





    }
}
