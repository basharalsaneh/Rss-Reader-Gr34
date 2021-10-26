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
            

        public void CreateFeed(string url, List<Episode> episodes, int numberOfEpisodes, string title)
        {
            Feed feed = new Feed(url, episodes, numberOfEpisodes, title);
            feedRepository.Add(feed);
        }


    }
}
