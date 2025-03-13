using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Battle

{
    public Trainer trainer;
    public Trainer trainer2;

    public Battle(Trainer trainer, Trainer trainer2)
    {
        this.trainer = trainer;
        this.trainer2 = trainer2;
    }


    public string BattleActions()
    {

        Pokeball ChosenPokemonFromTrainer1 = this.trainer.GrabFromBelt();
        this.trainer.ThrowPokeball(this.trainer.name, ChosenPokemonFromTrainer1);
        Pokeball ChosenPokemonFromTrainer2 = this.trainer2.GrabFromBelt();
        this.trainer2.ThrowPokeball(this.trainer2.name, ChosenPokemonFromTrainer2);

        return BattleCheck(ChosenPokemonFromTrainer1, ChosenPokemonFromTrainer2);
    }


    public string BattleCheck(Pokeball ChosenPokemonFromTrainer1, Pokeball ChosenPokemonFromTrainer2)
    {
        if (ChosenPokemonFromTrainer1.pokemonDetails.weakness == ChosenPokemonFromTrainer2.pokemonDetails.type) //player 1 wins
        {
            ChosenPokemonFromTrainer2.pokemonDetails.isFainted = true;
            return "trainer1";
        }
        if (ChosenPokemonFromTrainer2.pokemonDetails.weakness == ChosenPokemonFromTrainer1.pokemonDetails.type) //player 2 wins
        {
            ChosenPokemonFromTrainer1.pokemonDetails.isFainted = true;
            return "trainer2";
        }
        else
        {
            // trainer.lastMatchWon
            return "draw";
        }
    }

    //    for (int ballNumber = 0; ballNumber< 6; ballNumber++)
    //            {
    //                //Pokemon beestje = Trainer.ThrowPokeball(trainer.name,trainer.belt[ballNumber]);

    //                trainer.ThrowPokeball(trainer.name, trainer.belt[ballNumber]);
    //                trainer.belt[ballNumber].pokemonDetails.battleCry();
    //                trainer.ThrowPokeball(trainer2.name, trainer2.belt[ballNumber]);
    //                trainer2.belt[ballNumber].pokemonDetails.battleCry();

    //                trainer.RecallPokemon(trainer.name, trainer.belt[ballNumber]);
    //                trainer2.RecallPokemon(trainer2.name, trainer2.belt[ballNumber]);


    //            }


}
