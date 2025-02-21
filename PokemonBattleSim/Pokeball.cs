using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class Pokeball 
{
    public Pokemon pokemonDetails;
    private bool isClosed = true;
    private bool containsPokemon = true;

    public Pokeball(Pokemon pokemonDetails, bool isClosed, bool containsPokemon)
    {
        this.pokemonDetails = pokemonDetails;
        this.isClosed = isClosed;
        this.containsPokemon = containsPokemon;
    }

    // open

    public void ThrowPokemon(string trainerName)
    {
        this.isClosed = false;
        Console.WriteLine($"{trainerName} throws a pokeball");
        Console.WriteLine($"Go {this.pokemonDetails.getName()}!");
    }
    public void RecallPokemon(string trainerName)
    {
        this.isClosed = true;
        Console.WriteLine($"{trainerName} recalls the pokemon");
        Console.WriteLine($"Come back {this.pokemonDetails.getName()}!");
    }

    public void ShowPokemon()
    {
        Console.WriteLine($"Pokemon: {this.pokemonDetails.getName()}");
    }

    public void ShowStats()
    {
        Console.WriteLine($"Name: {pokemonDetails.name}, type: {pokemonDetails.type}, weakness: {pokemonDetails.weakness}");
    }
}



