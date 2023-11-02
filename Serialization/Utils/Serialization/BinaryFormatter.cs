using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization.Utils.Serialization;

public static class BinaryFormatterHelper
{
    [Obsolete("Obsolete")]
    public static void SerializeObject<T>(string filename, T obj)
    {
        using (FileStream fs = new FileStream(filename, FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, obj);
        }
    }

    [Obsolete("Obsolete")]
    public static T DeserializeObject<T>(string filename)
    {
        using (FileStream fs = new FileStream(filename, FileMode.Open))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            return (T)formatter.Deserialize(fs);
        }
    }
}
