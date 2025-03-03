using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetCatalog
{
    class PlanetCatalog
    {
        private List<Planet> planets;
        private int requestCount = 0;

        public PlanetCatalog()
        {
            planets = new List<Planet>
            {
                new Planet { Name = "Venus", OrderNumber = 2, EquatorLength = 38025, PreviousPlanet = null },
                new Planet { Name = "Earth", OrderNumber = 3, EquatorLength = 40075, PreviousPlanet = null },
                new Planet { Name = "Mars", OrderNumber = 4, EquatorLength = 21344, PreviousPlanet = null }
            };
        }

        public (int, double, string) GetPlanet(string name)
        {
            requestCount++;
            if (requestCount % 3 == 0){ return (0, 0, "Вы спрашиваете слишком часто");}

            var planet = planets.Find(p => p.Name.Equals(name)); //лаконичненько))

            if (planet != null) { return (planet.OrderNumber, planet.EquatorLength, "");}
            

            return (0, 0, "Не удалось найти планету");
        }
    }
}
