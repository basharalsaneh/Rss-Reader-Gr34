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
            try
            {
                if (input == null || input == "")
                {
                    isValid = false;
                    throw new TextEmptyException("Tomt textfält");
                }

            }
            
            catch (TextEmptyException e)
            {
                
            }

            return isValid;
        }

        public static bool CheckIfFeedExistsByUrl(string url)
        {
            bool itExists = true;

            //FeedRepository feedRepository = new FeedRepository();
            FeedHandler feedHandler = new FeedHandler();

            if (!feedHandler.GetAllFeeds().Exists(x => x.Url.Equals(url)))
            {
                itExists = false;
            }    

            return itExists;

        }

        public static bool CheckIfFeedExistsByName(string name)
        {
            bool itExists = true;

            FeedHandler feedHandler = new FeedHandler();

            if (!feedHandler.GetAllFeeds().Exists(x => x.Title.Equals(name)))
            {
                itExists = false;
            }

            return itExists;

        }



        public static bool CategoryExists(string categoryName)
        {
            bool itExists = true;

            //CategoryRepository categoryRepository  = new CategoryRepository();
            CategoryHandler categoryHandler = new CategoryHandler();
            

            if (!categoryHandler.GetAllCategories().Exists(x => x.Title.Equals(categoryName)))
            {
                itExists = false;
            }

            return itExists;

        }
         




       






    }

  
}
