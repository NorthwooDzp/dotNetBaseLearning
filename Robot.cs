namespace ConsoleApp1;

public class Robot
{
    private string Name { get; set; }
    private short Weight { get; set; }
    private byte[] Coordinates { get; set; }

    public Robot(string name, short weight, byte[] coordinates)
    {
        Console.WriteLine("Creating new Robot");
        SetProps(name, weight, coordinates);
    }

    private void SetProps(string name, short weight, byte[] coordinates)
    {
        Name = name;
        Weight = weight;
        Coordinates = coordinates;
    }

    public void LogProps()
    {
        Console.WriteLine($"Robot name => {Name}");
        Console.WriteLine($"Robot weight => {Weight} kg");
        Console.Write($"Coordinates =>");
        foreach (var coordinate in Coordinates)
        {
            Console.Write($" {coordinate}");
        }
    }
}