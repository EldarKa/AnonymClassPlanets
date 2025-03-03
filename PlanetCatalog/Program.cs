namespace PlanetCatalog
{
    internal class Program
    {
        static void Main()
        {
            PlanetCatalog catalog = new PlanetCatalog();

            PrintResult("Earth", catalog.GetPlanet("Earth"));
            PrintResult("Limonia", catalog.GetPlanet("Limonia"));
            PrintResult("Mars", catalog.GetPlanet("Mars"));
            PrintResult("Mars", catalog.GetPlanet("Mars"));
        }

        static void PrintResult(string name, (int, double, string) result)
        {
            if (result.Item3 == "")
            {
                Console.WriteLine(name);
                Console.WriteLine(result.Item1);
                Console.WriteLine(result.Item2);
            }
            else
            {
                Console.WriteLine(result.Item3);
            }
        }
    }
}
