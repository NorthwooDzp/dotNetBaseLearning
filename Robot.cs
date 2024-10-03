namespace ConsoleApp1;

public class Robot
{
    private string name;

    private short weight;

    private byte[] coordinates;

    public short Weight
    {
        get
        {
            Console.WriteLine("Getter has been called");
            return weight;
        }
        set => weight = value;
    }
    
    public int Width { get ; private set; }

    public Robot(string name, short weight, byte[] coordinates)
    {
        Console.WriteLine("Creating new Robot");
        SetProps(name, weight, coordinates);
    }

    public void LogProps()
    {
        Console.WriteLine($"Robot name => {name}");
        Console.WriteLine($"Robot weight => {weight} kg");
        Console.Write($"Coordinates =>");
        foreach (var coordinate in coordinates)
        {
            Console.Write($" {coordinate}");
        }

        Console.WriteLine("");
        Console.WriteLine("=====*******=====");
    }

    private void SetProps(string name, short weight, byte[] coordinates)
    {
        this.name = name;
        this.weight = weight;
        this.coordinates = coordinates;
    }
}