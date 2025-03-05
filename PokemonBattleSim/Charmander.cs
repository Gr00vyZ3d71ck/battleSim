using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

class Charmander : Pokemon
{
    public Charmander(string name) : base(name, "Fire", "Water")
    {
    }

    public override void battleCry()
    {
        Console.WriteLine($"{name} roept: {name}!");
    }
}

