namespace GetPlanetWithFunc
{
    internal class Program
    {
        static void Main()
        {
            PlanetCatalog catalog = new PlanetCatalog();
            int requestCounter = 0;
            Func<string, string> f1 = (name) =>
            {
                requestCounter++;
                return requestCounter % 3 == 0 ? "Вы спрашиваете слишком часто" : "";
            };
            Func<string, string> f2 = (name) =>
            {
                return name == "Limonia" ? "Это запретная планета" : "";
            };
            PrintResult("Earth", catalog.GetPlanet("Earth", f1));
            PrintResult("Limonia", catalog.GetPlanet("Limonia", f1));
            PrintResult("Mars", catalog.GetPlanet("Mars", f1));

            PrintResult("Earth", catalog.GetPlanet("Earth", f2));
            PrintResult("Limonia", catalog.GetPlanet("Limonia", f2));
            PrintResult("Mars", catalog.GetPlanet("Mars", f2));
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
