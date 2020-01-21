using Project.Models;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Project.Utilities
{
    static class Utilities
    {
        public static DataWrapper ReadFromXML_Serialize()
        {
            string filePath = "Data_Serialize.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(DataWrapper));
            try
            {
                StreamReader reader = new StreamReader(filePath);
                DataWrapper clients = (DataWrapper)serializer.Deserialize(reader);
                reader.Close();
                return clients;
            }
            catch(Exception)
            {
                DataWrapper data = new DataWrapper();
                Service service1 = new Service("haircut");
                Service service2 = new Service("hair makeup");
                Service service3 = new Service("dyeing hair");
                data.Services.Add(service1);
                data.Services.Add(service2);
                data.Services.Add(service3);
                return data;
            }
        }

        public static void WriteToXML_Serialize(DataWrapper list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DataWrapper));
            TextWriter writer = new StreamWriter("Data_Serialize.xml");
            serializer.Serialize(writer, list);

            writer.Close();
        }
    }
}
