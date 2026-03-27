namespace lab3;

public class Furniture
{
    public string Material { get; set; }
    public string Name { get; set; }
    public string Destination { get; set; }
    public int Price { get; set; }
    public int Year { get; set; }

    public Furniture(string name, string material, string destination, int price, int year)
    {
        Name = name;
        Material = material;
        Destination = destination;
        Price = price;
        Year = year;
    }
    
    public override string ToString()
    {
        return $"{Name} ({Material}, {Destination}) | Ціна: {Price} | Рік: {Year}";
    }
}