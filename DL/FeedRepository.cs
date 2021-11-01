using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DL
{

    public class FeedRepository : IRepository<Feed>
    {
       private static List<Feed> listOfFeeds = new List<Feed>();
        //FeedSerializer serializer = new FeedSerializer();
        FeedSerializer serializer = new FeedSerializer();


        public FeedRepository()
        {
            listOfFeeds = GetAll();
        }


        public void Add(Feed feed)
        {

            listOfFeeds.Add(feed);
            SaveChanges();

        }

        public List<Feed> GetAll()
        {
            List<Feed> listOfFeedsDeserialized = new List<Feed>();
            try
            {

                listOfFeedsDeserialized = serializer.Deserialize();
            }
            catch(Exception)
            {

            }
            

            return listOfFeedsDeserialized;
        }

        public List<Feed> GetAllFeedsByCategory(Category category)
        {
            return GetAll().FindAll(feed => feed.Category.Title.Equals(category.Title));
        }

        public Feed GetFeed(string url)
        {
            Feed feed = GetAll().FirstOrDefault(feed => feed.Url.Equals(url));
            return feed;

        }


        public int GetIndex(string name)
        {
            int index = GetAll().FindIndex(f => f.Title.Equals(name));
            return index;
        }

        public string HamtaAvsnittsBeskrivning(int valdFeed, int valtAvsnitt)
        {
            
                return listOfFeeds[valdFeed].EpisodeList[valtAvsnitt].Summary;
            
        }

        public void RemoveFeed(string title)
        {

            Feed feed = listOfFeeds.FirstOrDefault(feed => feed.Title.Equals(title));
            listOfFeeds.Remove(feed);
            SaveChanges();
        }

        public void RemoveFeed(Category category) //Method overloading
        {
            listOfFeeds.RemoveAll(feed => feed.Category.Title.Equals(category.Title));

            SaveChanges();
        }

        public void UpdateFeedCategory(string oldCategory, string newCategory, string feedName)
        {

            Feed feed = listOfFeeds.Find(feed => feed.Title.Equals(feedName));

            if (feed.Category.Title.Equals(oldCategory))
            {
                feed.Category.Title = newCategory;
            }

            SaveChanges();
        }

        public void UpdateFeedCategory(string oldCategory, string newCategory)
        {
            foreach (Feed feed in listOfFeeds)
            {
                if (feed.Category.Title.Equals(oldCategory))
                {
                    feed.Category.Title = newCategory;
                }
            }
            SaveChanges();
        }

       

        public void UpdateFeedName(string oldName, string newName)
        {
            foreach (Feed feed in listOfFeeds)
            {
                if (feed.Title.Equals(oldName))
                {
                    feed.Title = newName;
                }
            }
            SaveChanges();
        }

        public void UpdateFrekvens(string feedName, string frekvens)
        {
            foreach (Feed feed in listOfFeeds)
            {
                if (feed.Title.Equals(feedName))
                {
                    feed.UpdateInterval = frekvens;
                }
            }
            SaveChanges();
        }


        public static string[] LoadFrekvens()
        {
            return Frekvens.LoadFrekvenser();
        }

        public void SaveChanges()
        {
            serializer.Serialize(listOfFeeds);
        }


    }
}
