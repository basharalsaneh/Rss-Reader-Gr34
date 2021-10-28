using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    [Serializable]
    public class Feed
    {
        
        public string Url { get; set; }
        
        public List<Episode> EpisodeList { get; set; }
        
        public int NumberOfEpisodes { get; set; }
        
        public string Title { get; set; }
        
        public Category Category { get; set; }

        public string UppdateringsFrekvens { get; set; }
        public DateTime SenastUppdaterad { get; set; }

        public Feed(string url, List<Episode> episodes, int numberOfEpisodes, string title, Category category)

        {
            Url = url;
            EpisodeList = episodes;
            NumberOfEpisodes = numberOfEpisodes;
            Title = title;
            Category = category;
        }

        private Feed()
        {

        }
    }
}
