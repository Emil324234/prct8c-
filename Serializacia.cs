using System;
using System.IO;
using System.Xml.Serialization;

namespace Libraly
{
    public class Serializacia
    {
        public class Serialization
        {
            public static void Serialize<T>(T obj, string filePath)
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, obj);
                }
            }

            public static T Deserialize<T>(string filePath)
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(reader);
                }
            }
        }
    }
}
