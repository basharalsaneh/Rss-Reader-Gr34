using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TextEmptyException : Exception
    {
        public TextEmptyException(string message) : base(message)
        {

        }
    }
}
