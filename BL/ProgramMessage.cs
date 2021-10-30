using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public abstract class ProgramMessage
    {
        public ProgramMessage()
        {
            
        }

        public virtual string DisplayMessage()
        {
            return "Meddelande: ";
        }
        

    }
}
