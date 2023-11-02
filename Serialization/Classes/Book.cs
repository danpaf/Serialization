using System.Xml.Serialization;

namespace Serialization.Classes;

[Serializable]
public class Book
{
    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("Author")]
    public string Author { get; set; }

    [XmlElement("Year")]
    public int Year { get; set; }

    [XmlElement("Price")]
    public double Price { get; set; }

    public Book() { }

    public Book(string title, string author, int year, double price)
    {
        Title = title;
        Author = author;
        Year = year;
        Price = price;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Year: {Year}, Price: {Price:C}";
    }
}