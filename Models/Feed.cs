using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Feed
    {
        public string Url { get; set; }
        public List<Episode> EpisodeList { get; set; }
        public int NumberOfEpisodes { get; set; }
        public string Title { get; set; }


        public Feed(string url, List<Episode> episodes, int numberOfEpisodes, string title)
        {
            Url = url;
            EpisodeList = episodes;
            NumberOfEpisodes = numberOfEpisodes;
            Title = title;
        }

    }
}
