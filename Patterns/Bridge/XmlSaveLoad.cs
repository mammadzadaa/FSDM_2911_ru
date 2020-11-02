using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Bridge
{
    partial class Program
    {
        public class XmlSaveLoad<T> : ISaveLoad<T> where T : class
        {
            public void Save(List<T> data, string path)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                using (FileStream fs = new FileStream(path,FileMode.Create))
                {
                    serializer.Serialize(fs, data);
                }                
            }

            List<T> ISaveLoad<T>.Load(string path)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                     return serializer.Deserialize(fs) as List<T>;
                }
            }
        }
}

}
