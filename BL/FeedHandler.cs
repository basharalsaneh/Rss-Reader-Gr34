using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DL;

namespace BL
{
    public class FeedHandler
    {

        FeedRepository feedRepository;
        public FeedHandler()
        {
             feedRepository = new FeedRepository();

        }

        public Feed GetFeedByUrl(string url)
        {
            return feedRepository.GetFeed(url);
        }


        public List<Feed> GetAllFeeds()
        {
            return feedRepository.GetAll();
        }

        public List<Feed> GetAllFeedsByCategory(Category category)
        {
            return feedRepository.GetAllFeedsByCategory(category);
        }
            

        public void CreateFeed(string url, List<Episode> episodes, int numberOfEpisodes, string title, Category category, string frekvens)
        {
            Feed feed = new Feed(url, episodes, numberOfEpisodes, title, category, frekvens);

            feedRepository.Add(feed);

            
        }

       public int GetFeedIndex(string name)
        {
            return feedRepository.GetIndex(name);
        }

        public string HamtaAvsnittsBeskrivning(int valdFeed, int valtAvsnitt)
        {
          return  feedRepository.HamtaAvsnittsBeskrivning(valdFeed, valtAvsnitt);
        }


        public void RemoveFeed(string title)
        {
            feedRepository.RemoveFeed(title);
        }

        public void RemoveFeed(Category category) // Method overloading
        {
            feedRepository.RemoveFeed(category);
        }

        public void UpdateFeedCategory(string oldCategory, string newCategory, string feedName)
        {
            feedRepository.UpdateFeedCategory(oldCategory, newCategory, feedName);
        }

        public void UpdateFeedCategory(string oldCategory, string newCategory) //Method overloading
        {
            feedRepository.UpdateFeedCategory(oldCategory, newCategory);
        }

        public void UpdateFeedName(string oldName, string newName)
        {
            feedRepository.UpdateFeedName(oldName, newName);
        }

        public void UpdateFeedUpdateInterval(string feedName, string frekvens)
        {
            feedRepository.UpdateFrekvens(feedName, frekvens);
        }

        public static string[] LoadFrekvens()
        {
            return FeedRepository.LoadFrekvens();
        }





    }
}
