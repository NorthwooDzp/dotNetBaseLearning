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
        LogProps();
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
        Console.WriteLine("");
        Console.WriteLine("=====*******=====");
    }

    private void SetProps(string Name, short Weight, byte[] Coordinates)
    {
        this.Name = Name;
        this.Weight = Weight;
        this.Coordinates = Coordinates;
    }
}