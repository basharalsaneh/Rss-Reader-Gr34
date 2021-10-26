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
        feedHandler feedRepository;
        public FeedHandler()
        {
             feedRepository = new feedHandler();
        }

        public Feed GetFeedByUrl(string url)
        {
            return feedRepository.GetFeed(url);
        }

        public List<Feed> GetAllFeeds()
        {
            return feedRepository.GetAll();
        }
            

        public void CreateFeed(string url, List<Episode> episodes, int numberOfEpisodes, string title, Category category)
        {
            Feed feed = new Feed(url, episodes, numberOfEpisodes, title, category);


            feedRepository.Add(feed);

            
        }

       public int GetFeedIndex(string url)
        {
            return feedRepository.GetIndex(url);
        }

        public string HamtaAvsnittsBeskrivning(int valdFeed, int valtAvsnitt)
        {
          return  feedRepository.HamtaAvsnittsBeskrivning(valdFeed, valtAvsnitt);
        }


        public void removeFeed(int valtIndex)
        {
            feedRepository.removeFeed(valtIndex);
        }

    }
}
