using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Xml.Serialization;
using System.IO;

namespace DL
{
    public class Serializer<T> where T : class
    {
        virtual public void Serialize(List<T> list)
        {

        }

        virtual public List<T> Deserialize()
        {
            List<T> list = new List<T>();
            return list;
        }


    }
}
