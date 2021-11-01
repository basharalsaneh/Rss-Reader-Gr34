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
    class CategorySerializer : Serializer<Category>
    {
        public override void Serialize(List<Category> categoryList)
        {
            try
            {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Category>));
            using (FileStream outFile = new FileStream("Categories.xml", FileMode.Create,
                FileAccess.Write))
            {
                xmlSerializer.Serialize(outFile, categoryList);
            }
            }
            catch (Exception)
            {
                throw new SerializerException("Categories.xml", "Could not serialize to the file");
            }
        }

        public override List<Category> Deserialize()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Category>));
                using (FileStream inFile = new FileStream("Categories.xml", FileMode.Open,
                    FileAccess.Read))
                {
                    return (List<Category>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch (Exception)
            {
                throw new SerializerException("Categories.xml", "Could not deserialize the file.");
            }
        }
    }
}
