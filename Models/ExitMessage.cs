using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ExitMessage : ProgramMessage
    {
        public override string DisplayMessage()
        {
            return base.DisplayMessage() + "Är du säker på att du vill avsluta programmet?";
        }

    }
}
