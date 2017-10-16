using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace Memory
{
    class Utils
    {
        static Random rand = new Random();
        public static List<T> ShuffleList<T>(List<T> items) {
            items = items.OrderBy(x => rand.Next()).ToList();
            return items;
        }


        public static string ArrayToString(Array ar)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                SoapFormatter formatter = new SoapFormatter();
                formatter.Serialize(ms, ar);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        public static object StringToArray(string s)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(s)))
            {
                SoapFormatter formatter = new SoapFormatter();
                return formatter.Deserialize(ms) as Array;
            }
        }

    }



}
