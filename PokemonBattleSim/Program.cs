using System;
public class Test
{
    public static void Main()
    {
        Pokemon charmander = new Pokemon("Sparky","fire");
        Console.WriteLine(charmander.getName());
    }
}

class Pokemon
{
    public string name;
    public string strength;

    public Pokemon(string name, string strength)
    {
        this.name = name;
        this.strength = strength;
    }

    public string getName()
    {
        return name;
    }


}