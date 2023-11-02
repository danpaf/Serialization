using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Serialization.Classes; // Подключение вашего пространства имен

namespace Serialization.Utils.Serialization
{
    public class CustomXmlSerializer
    {
        public static void SerializeListToXml(string filename, List<Person> people)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
                serializer.Serialize(fs, people);
            }
        }

        public static List<Person> DeserializeListFromXml(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
                return ((List<Person>)serializer.Deserialize(fs)!)!;
            }
        }
        public static void SerializeBooksToXml(string filename, List<Book> books)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
                serializer.Serialize(fs, books);
            }
        }

        public static List<Book> DeserializeBooksFromXml(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
                return (List<Book>)serializer.Deserialize(fs)!;
            }
        }
    }
}