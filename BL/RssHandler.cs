using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.ServiceModel.Syndication;
using Models;
using DL;
using System.IO;


namespace BL
{
    public class RssHandler
    {

       
        public void GetRss(string url, string category)
        {
            
            FeedHandler feedHandler = new FeedHandler();
            EpisodeHandler episodeHandler = new EpisodeHandler();
            CategoryHandler categoryHandler = new CategoryHandler();
            
            SyndicationFeed syndicationFeed = SyndicationFeed.Load(XmlReader.Create(url));
            foreach (SyndicationItem item in syndicationFeed.Items)
            {
                string title = item.Title.Text;
                string summary = item.Summary.Text;
                episodeHandler.CreateEpisode(title, summary);
            }

            categoryHandler.CreateCategory(category);

            feedHandler.CreateFeed(url, episodeHandler.GetAllEpisodes(), episodeHandler.GetAllEpisodes().Count, syndicationFeed.Title.Text, categoryHandler.GetCategoryByName(category));
        }







    }


}
