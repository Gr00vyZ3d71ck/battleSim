using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Trainer
{
    public string name;
    public List<Pokeball> belt = new List<Pokeball>();
    Random random = new Random();
    public bool lastMatchWon;


    public Trainer(string name)
    {
        this.name = name;
        this.belt = new List<Pokeball>();
        this.lastMatchWon = false;
    }

    public void CreateBelt()
    {

    }
    //
    public void AddToBelt(Pokeball ball)
    {

        if (belt.Count == 6)
        {
            throw new ArithmeticException("Je belt mag niet meer dan 6 pokemon bevatten");
        }
        else
        {
            this.belt.Add(ball);
        }
        // try
        // {
        //     if (belt.Count < 6)
        //     {
        //         this.belt.Add(ball);
        //     }
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine($"{e.Message} De belt mag niet meer dan 6 pokeballs bevatten.");

        // }
        //try catch met error message toevoegen.

    }

    public void ShowBelt()
    {
        foreach (Pokeball ball in belt)
        {
            ball.ShowStats();
        }
    }

    public void ThrowPokeball(Pokeball ball)
    {
        Console.WriteLine($"{this.name} sends out {ball.pokemonDetails.name}");
        Console.WriteLine($"Go {ball.pokemonDetails.getName()}!");
        ball.OpenPokeball();
    }

    public Pokeball GrabFromBelt()
    {
        while (true)
        {
            int randomNumber = random.Next(0, 6);

            if (this.belt[randomNumber].pokemonDetails.isFainted == false)
            {
                return this.belt[randomNumber];
            }
        }
    }
    public void RecallPokemon(string trainerName, Pokeball ball)
    {
        Console.WriteLine($"{trainerName} recalls {ball.pokemonDetails.name}");
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

