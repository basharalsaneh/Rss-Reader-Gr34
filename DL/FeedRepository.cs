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


        public void Add(Feed feed)
        {
            listOfFeeds.Add(feed);
        }

        public List<Feed> GetAll()
        {
            return listOfFeeds;
        }

        public Feed GetFeed(string url)
        {
            Feed feed = listOfFeeds.FirstOrDefault(feed => feed.Url.Equals(url));
            return feed;

        }

        public static string HamtaAvsnittsBeskrivning(int valdFeed, int valtAvsnitt)
        {
            return listOfFeeds[valdFeed].EpisodeList[valtAvsnitt].Summary;
        }

    }
}
