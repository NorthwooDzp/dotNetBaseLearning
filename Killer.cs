namespace ConsoleApp1;

public class Killer : Robot
{
    public int Damage { get; private set; }

    public Killer()
    {
    }

    public Killer(string name, short weight, byte[] coordinates, int damage) : base(name, weight, coordinates, TypeRobot.ENEMY)
    {
        Damage = damage;
    }

    public void Laser()
    {
        Console.WriteLine("Shot ====>..........*****");
    }

    public override void LogProps()
    {
        base.LogProps();
        Console.WriteLine($"Damage => {Damage}");
    }

    public override void Move(float speed)
    {
        foreach (var coordinate in coordinates)
        {
            Console.WriteLine(coordinate + 2 * speed);
        }
    }
}