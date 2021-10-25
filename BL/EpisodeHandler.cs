using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using Models;

namespace BL
{
    public class EpisodeHandler
    {
        
        EpisodeRepository episodeRepository;
        public EpisodeHandler()
        {
            episodeRepository = new EpisodeRepository();
        }


        public List<Episode> GetAllEpisodes()
        {
            return episodeRepository.GetAll();
        }


        public void CreateEpisode(string title, string summary)
        {
            Episode episode = new Episode(title, summary);
            episodeRepository.Add(episode);
        }

        

    


    }
}
