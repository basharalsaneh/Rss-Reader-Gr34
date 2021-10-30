using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Episode
    {
        public string Title { get; set; }

        public string Summary { get; set; }


        public Episode(string title, string summary)
        {
            Title = title;
            Summary = summary;
      
        }


        private Episode()
        {

        }

    }

}
