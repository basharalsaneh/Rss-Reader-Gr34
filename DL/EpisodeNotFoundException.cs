using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    class EpisodeNotFoundException : Exception
    {
        public EpisodeNotFoundException(string message) : base(message)
        {

        }
    }
}
