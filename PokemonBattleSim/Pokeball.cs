using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class Pokeball
{
    public Pokemon pokemonDetails;//ball
    private bool isClosed = true;//bool voor closed of open
    private bool containsPokemon = true;//of de ball leeg is of niet

    public Pokeball(Pokemon pokemonDetails, bool isClosed, bool containsPokemon)
    {
        this.pokemonDetails = pokemonDetails;
        this.isClosed = isClosed;
        this.containsPokemon = containsPokemon;
    }

    // open

    public void ClosePokeball()
    {
        this.isClosed = true;
    }
    public Pokemon OpenPokeball() //hier nog naar kijken!! nog pokemondetails returnen zonder parameter -5/3/2025
    {
        this.isClosed = false;
        return this.pokemonDetails;
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



