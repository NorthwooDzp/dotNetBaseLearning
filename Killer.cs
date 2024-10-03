namespace ConsoleApp1;

public class Killer : Robot
{
    public int Damage { get; private set; }

    public Killer()
    {
    }

    public Killer(string name, short weight, byte[] coordinates, int damage): base(name, weight, coordinates)
    {
        Damage = damage;
        base.LogProps();
    }

    public void Laser()
    {
        Console.WriteLine("Shot ====>..........*****");
    }
}