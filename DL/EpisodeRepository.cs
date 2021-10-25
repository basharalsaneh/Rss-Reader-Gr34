using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DL
{
    public class EpisodeRepository :IRepository<Episode>
    {
        List<Episode> listOfEpisodes = new List<Episode>();

        public void Add(Episode episode)
        {
            listOfEpisodes.Add(episode);
        }

        public List<Episode> GetAll()
        {
            return listOfEpisodes;
        }


    }
    
}
