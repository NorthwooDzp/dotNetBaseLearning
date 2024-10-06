namespace ConsoleApp1;

public abstract class Robot
{
    private string name;

    private short weight;

    protected byte[] coordinates;

    private static int count = 0;

    protected TypeRobot type;

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

    public Robot(string name, short weight, byte[] coordinates, TypeRobot type)
    {
        Console.WriteLine("Creating new Robot");
        count++;
        SetProps(name, weight, coordinates, type);
    }

    public virtual void LogProps()
    {
        Console.WriteLine($"Robot name => {name}");
        Console.WriteLine($"Robot weight => {weight} kg");
        Console.Write($"Coordinates =>");
        foreach (var coordinate in coordinates)
        {
            Console.Write($" {coordinate}");
        }

        Console.WriteLine("");
    }

    private void SetProps(string name, short weight, byte[] coordinates, TypeRobot type)
    {
        this.name = name;
        this.weight = weight;
        this.coordinates = coordinates;
        this.type = type;
    }

    public abstract void Move(float speed);
}

