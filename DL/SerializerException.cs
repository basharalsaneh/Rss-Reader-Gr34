using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class SerializerException : Exception
    {
        private string filename;
        public string FileName { get; }

        public SerializerException(string fileName, string message) : base(message)
        {
            this.filename = fileName;
        }
    }
}
