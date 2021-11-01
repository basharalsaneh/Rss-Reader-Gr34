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

        public string UpdateInterval { get; set; }
        
        public DateTime NextUpdate { get; set; }

        public Feed(string url, List<Episode> episodes, int numberOfEpisodes, string title, Category category, string frekvens)

        {
            Url = url;
            EpisodeList = episodes;
            NumberOfEpisodes = numberOfEpisodes;
            Title = title;
            Category = category;
            UpdateInterval = frekvens;
            Update();
        }

        public bool NeedsUpdate
        {
            get
            {
                return NextUpdate <= DateTime.Now;
            }
        }

        public string Update()
        {
            // nästa uppdatering sker om "UpdateInterval" minuter
            // Vi hittar den tidpunkten genom att lägga till det antalet millisekunder till den 
            // nuvarande tiden.
            //string[] tokens = UpdateInterval.Split(' ');
            //string retVal = tokens[0] + " " + tokens[1];

            double updateInterval;
            Double.TryParse(UpdateInterval, out updateInterval);
            NextUpdate = DateTime.Now.AddMilliseconds(updateInterval);
            return Title + " uppdaterades. Nästa uppdatering sker: " + NextUpdate;
        }
      

        private Feed()
        {

        }
    }
}
