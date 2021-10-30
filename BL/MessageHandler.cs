using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class MessageHandler
    {

        public MessageHandler()
        {

        }

        public ProgramMessage CreateMessage(int programState)
        {
            ProgramMessage message = null;

            if (programState == 1)
            {
                message = new WelcomeMessage();
            }
            if (programState == 0)
            {
                message = new ExitMessage();
            }

            return message;
        }
            
    }
}
