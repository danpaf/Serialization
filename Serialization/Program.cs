using System.Text.Json;
using Serialization.Classes;
using Serialization.Utils.Serialization;

Person person = new Person("Alice", 30);
Product product = new Product("Laptop", 1000.0);

string personJson = JsonSerializer.Serialize(person);
string productJson = JsonSerializer.Serialize(product);

File.WriteAllText("person.json", personJson);
File.WriteAllText("product.json", productJson);

string deserializedPersonJson = File.ReadAllText("person.json");
string deserializedProductJson = File.ReadAllText("product.json");

Person deserializedPerson = JsonSerializer.Deserialize<Person>(deserializedPersonJson)!;
Product deserializedProduct = JsonSerializer.Deserialize<Product>(deserializedProductJson)!;

Console.WriteLine("Deserialized Person: " + deserializedPerson);
Console.WriteLine("Deserialized Product: " + deserializedProduct);

List<Person> people = new List<Person>
{
    new Person("Alice", 30),
    new Person("Bob", 25),
    new Person("Charlie", 35)
};


CustomXmlSerializer.SerializeListToXml("people.xml", people);


List<Person> deserializedPeople = CustomXmlSerializer.DeserializeListFromXml("people.xml");


Console.WriteLine("Deserialized People:");
foreach (var item in deserializedPeople)
{
    Console.WriteLine(item);
}

Dictionary<string, Person> peopleDict = new Dictionary<string, Person>
{
    { "Alice", new Person("Alice", 30) },
    { "Bob", new Person("Bob", 25) },
    { "Charlie", new Person("Charlie", 35) }
};

CustomJsonSerializer.SerializeDictionaryToJson("people.json", peopleDict);

Dictionary<string, Person> deserializedPeopleDict = CustomJsonSerializer.DeserializeDictionaryFromJson("people.json");

Console.WriteLine("Deserialized People:");
foreach (var kvp in deserializedPeopleDict)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

List<Book> books = new List<Book>
{
    new Book("Book 1", "Author 1", 2020, 29.99),
    new Book("Book 2", "Author 2", 2019, 19.99),
    new Book("Book 3", "Author 3", 2022, 39.99)
};

CustomXmlSerializer.SerializeBooksToXml("books.xml", books);

List<Book> deserializedBooks = CustomXmlSerializer.DeserializeBooksFromXml("books.xml");

Console.WriteLine("Deserialized Books:");
foreach (var book in deserializedBooks)
{
    Console.WriteLine(book);
}