using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetPlanetWithFunc
{
    class PlanetCatalog
    {
        private List<Planet> planets;

        public PlanetCatalog()
        {
            planets = new List<Planet>
            {
                new Planet { Name = "Venus", OrderNumber = 2, EquatorLength = 38025, PreviousPlanet = null },
                new Planet { Name = "Earth", OrderNumber = 3, EquatorLength = 40075, PreviousPlanet = null },
                new Planet { Name = "Mars", OrderNumber = 4, EquatorLength = 21344, PreviousPlanet = null }
            };
        }

        public (int, double, string) GetPlanet(string name, Func<string, string> myError)
        {
            string error = myError(name);
            if (error != "")
            {
                return (0, 0, error);
            }
            var planet = planets.Find(p => p.Name.Equals(name)); //лаконичненько))

            if (planet != null) { return (planet.OrderNumber, planet.EquatorLength, "");}
            

            return (0, 0, "Не удалось найти планету");
        }
    }
}
