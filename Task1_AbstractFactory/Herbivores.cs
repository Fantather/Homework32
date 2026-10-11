public abstract class Herbivore
{
    protected Herbivore(string name, int weight)
    {
        Name = name;
        Weight = weight;
    }

    public string Name { get; }
    public int Weight { get; protected set; }
    public bool Life { get; private set; } = true;

    public abstract void EatGrass();

    public void Die()
    {
        Life = false;
    }
}

public class Wildebeest : Herbivore
{
    public Wildebeest() : base("Wildebeest", 100) { }

    public override void EatGrass()
    {
        Weight += 10;
        Console.WriteLine($"{Name} eats grass. Weight: {Weight}");
    }
}

public class Bison : Herbivore
{
    public Bison() : base("Bison", 300) { }

    public override void EatGrass()
    {
        Weight += 10;
        Console.WriteLine($"{Name} eats grass. Weight: {Weight}");
    }
}

public class Elk : Herbivore
{
    public Elk() : base("Elk", 200) { }

    public override void EatGrass()
    {
        Weight += 10;
        Console.WriteLine($"{Name} eats grass. Weight: {Weight}");
    }
}
