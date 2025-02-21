using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Squirtle : Pokemon
{
    public Squirtle(string name) : base(name, "Water", "Grass")
    {
    }
    public override void battleCry()
    {
        Console.WriteLine($"{name} roept: {name}!");
    }

}

