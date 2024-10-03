namespace ConsoleApp1;

public class Robot
{
    private string name;

    private short weight;

    private byte[] coordinates;

    private static int count = 0;

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

    public Robot()
    {
        count++;
        name = $"Simple bot #{count}";
        weight = 16;
        coordinates = new byte[] { 0, 0, 0 };
    }

    public Robot(string name, short weight, byte[] coordinates)
    {
        Console.WriteLine("Creating new Robot");
        count++;
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

