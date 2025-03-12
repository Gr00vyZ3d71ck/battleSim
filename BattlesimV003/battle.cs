using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Battle

{
    public string result;


    public string battle(Trainer trainer,Trainer trainer2)
    { 
        Pokeball ChosenPokemonFromTrainer1 = trainer.GrabFromBelt();
        trainer.ThrowPokeball(trainer.name,ChosenPokemonFromTrainer1);
        Pokeball ChosenPokemonFromTrainer2 = trainer2.GrabFromBelt();
        trainer2.ThrowPokeball(trainer2.name,ChosenPokemonFromTrainer2);

        return result = battleCheck(ChosenPokemonFromTrainer1, ChosenPokemonFromTrainer2);
    }
    

    public string battleCheck(Pokeball ChosenPokemonFromTrainer1,Pokeball ChosenPokemonFromTrainer2)
    {
        if(ChosenPokemonFromTrainer1.pokemonDetails.weakness == ChosenPokemonFromTrainer2.pokemonDetails.type) //player 1 wins
        {
            return "trainer1";
        }
        if(ChosenPokemonFromTrainer2.pokemonDetails.weakness == ChosenPokemonFromTrainer1.pokemonDetails.type) //player 2 wins
        { 
            return "trainer2";
        }
        else 
        {
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
