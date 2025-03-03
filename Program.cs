namespace AnonymClassPlanets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Venus = new 
            {
                Name = "Venus",
                OrderNumber = 2, 
                EquatorLength = 38025,
                PreviousPlanet = (object)null 
            };

            var Earth = new
            {
                Name = "Earth", OrderNumber = 3,
                EquatorLength = 40075,
                PreviousPlanet = Venus
            };

            var Mars = new 
            { 
                Name = "Mars",
                OrderNumber = 4,
                EquatorLength = 21344,
                PreviousPlanet = Earth 
            };
            var Venus2 = new
            {
                Name = "Venus", 
                OrderNumber = 2,
                EquatorLength = 38025,
                PreviousPlanet = (object)null 
            };

            // Вывод информации и сравнение объектов
            PrintPlanet(Venus, Venus2);
            PrintPlanet(Earth, Venus);
            PrintPlanet(Mars, Venus);
        }

        static void PrintPlanet(dynamic planet1, dynamic planet2)
        {
            Console.WriteLine($"Планета 1");
            WritePrintPlanet(planet1);
            Console.WriteLine($"Планета 2");
            WritePrintPlanet(planet2);

            // Сравнение через Equals
            Console.WriteLine(planet1.Equals(planet2) ? "Равны" : "Не равны");
            Console.WriteLine();
        }
        static void WritePrintPlanet(dynamic planet)
        {
            Console.WriteLine($"Имя: {planet.Name}");
            Console.WriteLine($"Номер: {planet.OrderNumber}");
            Console.WriteLine($"Длина экватора: {planet.EquatorLength} км");
            Console.WriteLine($"Предыдущая планета: {(planet.PreviousPlanet != null ? planet.PreviousPlanet.Name : "Нет")}");
        }
    }
}
