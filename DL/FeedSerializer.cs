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
    class FeedSerializer : Serializer<Feed> 
    {
        public override void Serialize(List<Feed> feedList)
        {
           try
            {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Feed>));
            using (FileStream outFile = new FileStream("Feeds.xml", FileMode.Create,
                FileAccess.Write))
            {
                xmlSerializer.Serialize(outFile, feedList);
            }
            }
            catch (Exception)
            {
               throw new SerializerException("Feeds.xml", "Failed serialization to file");
            }
        }

        public override List<Feed> Deserialize()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Feed>));
                using (FileStream inFile = new FileStream("Feeds.xml", FileMode.Open,
                    FileAccess.Read))
                {
                    return (List<Feed>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch (Exception)
            {
                throw new SerializerException("Feeds.xml", "Failed to deserialize the file.");

            }
        }

    }
}
