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

    public void ClosePokeball()
    {
        this.isClosed = false;
    }
    public void OpenPokeball()
    {
        this.isClosed = true;
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



