using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Trainer
{
    public string name;
    
    public List<Pokeball> belt = new List<Pokeball>();


    public Trainer(string name)
    {
        this.name = name;
        this.belt = new List<Pokeball>();
    }

    public void AddToBelt(Pokeball ball)
    {
        this.belt.Add(ball);
    }

    public void ShowBelt()
    {
        foreach (Pokeball ball in belt)
        {
            ball.ShowStats();
        }
    }

    public void ThrowPokeball(string trainerName,Pokeball ball)
    {
        Console.WriteLine($"{trainerName} sends out {ball.pokemonDetails.name}");
        Console.WriteLine($"Go {ball.pokemonDetails.getName()}!");
        ball.OpenPokeball();
    }
    public void RecallPokemon(string trainerName, Pokeball ball)
    {
        Console.WriteLine($"{trainerName} recalls the pokemon");
        Console.WriteLine($"Come back {ball.pokemonDetails.getName()}!");
        ball.ClosePokeball();
    }

    
    public void setTrainerName()
    {
        try
        {
            Console.WriteLine($"What name do you want {this.name} to have?");
            this.name = Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }





}

