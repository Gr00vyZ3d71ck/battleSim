using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class Pokeball
{
    private Pokemon pokemonDetails;
    private bool isClosed = true;
    private bool containsPokemon = true;

    public Pokeball(Pokemon pokemonDetails, bool isClosed, bool containsPokemon)
    {
        this.pokemonDetails = pokemonDetails;
        this.isClosed = isClosed;
        this.containsPokemon = containsPokemon;
    }


    public void ThrowPokemon()
    {
        this.isClosed = false;
        Console.WriteLine($"Go {this.pokemonDetails.getName()}!");
    }
    public void RecallPokemon()
    {
        this.isClosed = true;
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



