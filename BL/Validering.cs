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
            bool isValid = false;

            if (URL.StartsWith("https://") || URL.StartsWith("http://"))
            {
                isValid = true;
            }
            else
            {
                throw new InvalidUrlException("Den angivna URL:en är inte giltig");
            }

            return isValid;

            //return URL.StartsWith("https://") || URL.StartsWith("http://") ? true : false;
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
                    throw new TextEmptyException("Följande textfält måste fyllas i: ");
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
            else
            {
                throw new EntityExistsException("Denna feed existerar redan");
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
            else
            {
                throw new EntityExistsException("En feed med samma namn existerar redan");
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
            else
            {
                throw new EntityExistsException("Denna kategori existerar redan");
            }

            return itExists;

        }
         




       






    }

  
}
