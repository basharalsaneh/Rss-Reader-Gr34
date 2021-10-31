using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Threading;
using Models;
using DL;
using System.IO;


namespace BL
{
    public class RssHandler
    {

       
        public async Task CreateRssAsync(string url, Category category, string frekvens)
        {
            await Task.Run(() =>
            {
                //Thread.Sleep(5000);
                try
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

                    //categoryHandler.GetCategoryByName(category);

                    feedHandler.CreateFeed(url, episodeHandler.GetAllEpisodes(), episodeHandler.GetAllEpisodes().Count, syndicationFeed.Title.Text, category, frekvens);
                }
                catch (Exception)
                {
                    

                }
            });
           
            
        }

        public void UpdateRss(string url, string feedName, Category category, string frekvens)
        {

            {
                //Thread.Sleep(5000);

                {
                    FeedHandler feedHandler = new FeedHandler();
                    EpisodeHandler episodeHandler = new EpisodeHandler();
                    CategoryHandler categoryHandler = new CategoryHandler();
                    List<Episode> updatedEpisodeList = new List<Episode>();

                    //foreach(Episode episode in episodes)
                    //{
                    //    episodeHandler.RemoveEpisode(episode);
                    //}

                    SyndicationFeed syndicationFeed = SyndicationFeed.Load(XmlReader.Create(url));
                    foreach (SyndicationItem item in syndicationFeed.Items)
                    {
                        string title = item.Title.Text;
                        string summary = item.Summary.Text;
                        episodeHandler.CreateEpisode(title, summary);
                    }

                    //foreach(Episode episode in episodeHandler.GetAllEpisodes())
                    //{
                    //    updatedEpisodeList.Add(episode);
                    //}

                    //categoryHandler.GetCategoryByName(category);

                    feedHandler.CreateFeed(url, episodeHandler.GetAllEpisodes(), episodeHandler.GetAllEpisodes().Count, feedName, category, frekvens);
                    //Feed feed = feedHandler.GetFeedByUrl(url);
                    ////return episodeHandler.GetAllEpisodes();
                    //return feed;

                }
                
            }
           


        }







    }


}
