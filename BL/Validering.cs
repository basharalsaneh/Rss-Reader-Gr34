using System;
using System.Linq;

namespace BL
{
    public class Validering
    {
        public static bool CheckURL(string URL)
        {
            return URL.StartsWith("https://") || URL.StartsWith("http://") ? true : false;
        }

        public static bool OmDublett(string nyttInnehall, string[] innehall)
        {
            return innehall.Any((g) => String.Equals(g, nyttInnehall, StringComparison.OrdinalIgnoreCase));
        }
    }

  
}
