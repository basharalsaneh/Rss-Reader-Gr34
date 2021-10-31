using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    class Frekvens
    {
        private static List<Feed> listOfFeeds = new List<Feed>();

        public static string[] frekvensLista = {
            "60000 (1 min)",
            "300000 (5 min)",
            "600000 (10 min)",
            "1800000 (30 min)"
            //"1 minut",
            //"5 minuter",
            //"15 minuter",
            //"30 minuter"
        };


        public static string[] LoadFrekvenser()
        {
            return frekvensLista;
        }

      

    }
}
