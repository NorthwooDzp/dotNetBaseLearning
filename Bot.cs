namespace ConsoleApp1;

public class Bot : Robot
{
    public Bot()
    {
    }

    public Bot(string name, short weight, byte[] coordinates) : base(name, weight, coordinates)
    {
    }
    
    public override void Move(float speed)
    {
        foreach (var coordinate in coordinates)
        {
            Console.WriteLine(coordinate + 6 * speed);
        }
    }
}