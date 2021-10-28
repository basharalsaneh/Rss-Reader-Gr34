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
            //return listOfFeeds;

            List<Feed> listOfFeedsDeserialized = new List<Feed>();
            try
            {
                listOfFeedsDeserialized = serializer.Deserialize();
            }
            catch (Exception)
            {
                

            }

            return listOfFeedsDeserialized;
        }

        public Feed GetFeed(string url)
        {
            Feed feed = GetAll().FirstOrDefault(feed => feed.Url.Equals(url));
            return feed;

            //Feed feed = listOfFeeds.Select(feed => feed).Where(feed => feed.Url.Equals(url));
            //return feed;

        }

        public int GetIndex(string url)
        {
            int index = listOfFeeds.FindIndex(f => f.Url.Equals(url));
            return index;
        }

        public string HamtaAvsnittsBeskrivning(int valdFeed, int valtAvsnitt)
        {
            return listOfFeeds[valdFeed].EpisodeList[valtAvsnitt].Summary;
        }

        public void RemoveFeed(string title)
        {
            //listOfFeeds.Remove(listOfFeeds[valtIndex]);

            Feed feed = listOfFeeds.FirstOrDefault(feed => feed.Title.Equals(title));
            listOfFeeds.Remove(feed);
            SaveChanges();
        }

        public void RemoveFeed(Category category) //Method overloading
        {
            //Feed feed = listOfFeeds.FirstOrDefault(feed => feed.Category.Title.Equals(category.Title));
            listOfFeeds.RemoveAll(feed => feed.Category.Title.Equals(category.Title));

            //listOfFeeds.RemoveAll(feed => feed.Category.Equals(category));
            SaveChanges();
        }

        public void UpdateFeedCategory(string oldCategory, string newCategory)
        {
            //listOfFeeds.Where(x => x.Category.Title.Equals(oldCategory));

            foreach(Feed feed in listOfFeeds)
            {
                if(feed.Category.Title.Equals(oldCategory))
                {
                    feed.Category.Title = newCategory;
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
            //serializer.SerializeFeed(listOfFeeds);
        }





    }
}
