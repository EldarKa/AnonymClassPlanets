using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Planet
{
    public string Name { get; set; }
    public int OrderNumber { get; set; }
    public double EquatorLength { get; set; }
    public Planet PreviousPlanet { get; set; }
}
