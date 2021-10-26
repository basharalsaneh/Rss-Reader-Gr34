﻿using System;
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
            if (!listOfFeeds.Exists(x => x.Url.Equals(feed.Url)))
            {
                listOfFeeds.Add(feed);
            }
            else
            {
                
            }

               
        }

        public List<Feed> GetAll()
        {
            return listOfFeeds;
        }

        public Feed GetFeed(string url)
        {
            Feed feed = listOfFeeds.FirstOrDefault(feed => feed.Url.Equals(url));
            return feed;

            //Feed feed = listOfFeeds.Select(feed => feed).Where(feed => feed.Url.Equals(url));
            //return feed;

        }

        public int GetIndex(string url)
        {
            int index = listOfFeeds.FindIndex(f => f.Url.Equals(url));
            return index;
        }

        public static string HamtaAvsnittsBeskrivning(int valdFeed, int valtAvsnitt)
        {
            return listOfFeeds[valdFeed].EpisodeList[valtAvsnitt].Summary;
        }

    }
}
