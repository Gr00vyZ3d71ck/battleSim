using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Bulbasaur : Pokemon
{
    public Bulbasaur(string name) : base(name, "Grass", "Fire",false)
    {
    }
    public override void battleCry()
    {
        Console.WriteLine($"{name} roept: {name}!");
    }
}

