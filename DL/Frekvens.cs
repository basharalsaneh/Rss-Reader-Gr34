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
            "10 minuter",
            "1 timme",
            "1 dag",
            "1 vecka"
        };


        public static string[] LoadFrekvenser()
        {
            return frekvensLista;
        }

      

    }
}
