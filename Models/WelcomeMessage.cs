using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class WelcomeMessage : ProgramMessage
    {
        public override string DisplayMessage()
        {
            return base.DisplayMessage() + ("Välkommen till Grupp 34s RSS läsare");
        }

    }
}
