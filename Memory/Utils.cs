using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Utils
    {
        public static Random rand = new Random();
        public static List<T> ShuffleList<T>(List<T> items) {
            items = items.OrderBy(x => rand.Next()).ToList();
            return items;
        }
    }
}
