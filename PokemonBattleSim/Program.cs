using System;


public class Test
{
    public static void Main()
    {
        Console.WriteLine("What name would you like to give to your Charmander?");

        string name = Console.ReadLine();

        Pokemon charmander = new Pokemon(name, "fire", "water");
        charmander.showStats();
    }
}

class SetData
{

}

class Moveset
{


}