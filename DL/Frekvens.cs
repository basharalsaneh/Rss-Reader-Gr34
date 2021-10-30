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
            "60000",
            "300000",
            "600000",
            "1800000"
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
