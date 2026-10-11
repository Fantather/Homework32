public abstract class Continent
{
    public abstract string Name { get; }

    public abstract Herbivore CreateHerbivore();
    public abstract Carnivore CreateCarnivore();
}

public class Africa : Continent
{
    public override string Name => "Africa";

    public override Herbivore CreateHerbivore()
    {
        return new Wildebeest();
    }

    public override Carnivore CreateCarnivore()
    {
        return new Lion();
    }
}

public class NorthAmerica : Continent
{
    public override string Name => "North America";

    public override Herbivore CreateHerbivore()
    {
        return new Bison();
    }

    public override Carnivore CreateCarnivore()
    {
        return new Wolf();
    }
}

public class Eurasia : Continent
{
    public override string Name => "Eurasia";

    public override Herbivore CreateHerbivore()
    {
        return new Elk();
    }

    public override Carnivore CreateCarnivore()
    {
        return new Tiger();
    }
}
