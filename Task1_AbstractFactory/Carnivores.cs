public abstract class Carnivore
{
    protected Carnivore(string name, int power)
    {
        Name = name;
        Power = power;
    }

    public string Name { get; }
    public int Power { get; protected set; }

    public abstract void Eat(Herbivore herbivore);
}

public class Lion : Carnivore
{
    public Lion() : base("Lion", 120) { }

    public override void Eat(Herbivore herbivore)
    {
        if (Power > herbivore.Weight)
        {
            Power += 10;
            herbivore.Die();
            Console.WriteLine($"{Name} ate {herbivore.Name}. Power: {Power}");
        }
        else
        {
            Power -= 10;
            Console.WriteLine($"{Name} failed to catch {herbivore.Name}. Power: {Power}");
        }
    }
}

public class Wolf : Carnivore
{
    public Wolf() : base("Wolf", 80) { }

    public override void Eat(Herbivore herbivore)
    {
        if (Power > herbivore.Weight)
        {
            Power += 10;
            herbivore.Die();
            Console.WriteLine($"{Name} ate {herbivore.Name}. Power: {Power}");
        }
        else
        {
            Power -= 10;
            Console.WriteLine($"{Name} failed to catch {herbivore.Name}. Power: {Power}");
        }
    }
}

public class Tiger : Carnivore
{
    public Tiger() : base("Tiger", 230) { }

    public override void Eat(Herbivore herbivore)
    {
        if (Power > herbivore.Weight)
        {
            Power += 10;
            herbivore.Die();
            Console.WriteLine($"{Name} ate {herbivore.Name}. Power: {Power}");
        }
        else
        {
            Power -= 10;
            Console.WriteLine($"{Name} failed to catch {herbivore.Name}. Power: {Power}");
        }
    }
}
