Continent[] continents = { new Africa(), new NorthAmerica(), new Eurasia() };

foreach (var continent in continents)
{
    AnimalWorld world = new AnimalWorld(continent);
    world.MealsHerbivores();
    world.NutritionCarnivores();
    Console.WriteLine();
}
