using System;
using System.Linq;
using Models;
using DL;


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


        public static bool CheckTextInput(string input)
        {
            bool isValid = true;

            if (input == null || input == "")
            {
                isValid = false;
            }

            return isValid;
        }

        public static bool FeedExists(string url)
        {
            bool itExists = true;


            FeedRepository feedRepository = new FeedRepository();


            if (!feedRepository.GetAll().Exists(x => x.Url.Equals(url)))
            {
                itExists = false;
            }

            return itExists;

        }

        public static bool CategoryExists(string categoryName)
        {
            bool itExists = true;

            CategoryRepository categoryRepository  = new CategoryRepository();

            if (!categoryRepository.GetAll().Exists(x => x.Title.Equals(categoryName)))
            {
                itExists = false;
            }

            return itExists;

        }


       






    }

  
}
