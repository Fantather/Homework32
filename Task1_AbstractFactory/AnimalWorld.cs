public class AnimalWorld
{
    private readonly List<Herbivore> _herbivores = new();
    private readonly List<Carnivore> _carnivores = new();

    public AnimalWorld(Continent continent)
    {
        Console.WriteLine($"=== {continent.Name} ===");
        _herbivores.Add(continent.CreateHerbivore());
        _carnivores.Add(continent.CreateCarnivore());
    }

    public void MealsHerbivores()
    {
        foreach (var herbivore in _herbivores.Where(h => h.Life))
            herbivore.EatGrass();
    }

    public void NutritionCarnivores()
    {
        foreach (var carnivore in _carnivores)
        {
            var prey = _herbivores.FirstOrDefault(h => h.Life);

            if (prey == null)
            {
                Console.WriteLine($"{carnivore.Name} found no prey.");
                continue;
            }

            carnivore.Eat(prey);
        }
    }
}
