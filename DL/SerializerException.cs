using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class SerializerException : Exception
    {
        public string FileName { get; set; }

        public SerializerException(string fileName, string message) : base(message)
        {
            FileName = fileName;
        }
    }
}
