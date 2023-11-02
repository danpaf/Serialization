using System.Runtime.Serialization.Json;
using Serialization.Classes;

namespace Serialization.Utils.Serialization;

public class CustomJsonSerializer
{
    public static void SerializeDictionaryToJson(string filename, Dictionary<string, Person> dict)
    {
        using (FileStream fs = new FileStream(filename, FileMode.Create))
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Dictionary<string, Person>));
            serializer.WriteObject(fs, dict);
        }
    }

    public static Dictionary<string, Person> DeserializeDictionaryFromJson(string filename)
    {
        using (FileStream fs = new FileStream(filename, FileMode.Open))
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Dictionary<string, Person>));
            return ((Dictionary<string, Person>)serializer.ReadObject(fs)!)!;
        }
    }
}