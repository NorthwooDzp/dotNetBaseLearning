namespace ConsoleApp1;

public class Killer : Robot
{
    public int Damage { get; private set; }

    public Killer()
    {
    }

    public Killer(string name, short weight, byte[] coordinates, int damage) : base(name, weight, coordinates)
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
}