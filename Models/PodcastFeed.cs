using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class PodcastFeed : Feed
    {
        public PodcastFeed(string url, List<Episode> episodes, int numberOfEpisodes, string title) : base(url, episodes, numberOfEpisodes, title)
        {

        }
    }
}
