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

        public static string[] frekvensLista = {
            "60000 (1 min)",
            "300000 (5 min)",
            "600000 (10 min)",
            "1800000 (30 min)"
        };


        public static string[] LoadFrekvenser()
        {
            return frekvensLista;
        }

      

    }
}
