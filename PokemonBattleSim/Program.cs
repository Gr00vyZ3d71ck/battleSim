using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
class Program 
{
    static void Main()
    {
        bool game = true;
        //2.The player gives a name to the first trainer.
        while (game) 
        { 
            Trainer trainer = new Trainer("trainer1");
            Trainer trainer2 = new Trainer("trainer2");

            trainer.setTrainerName();
            trainer2.setTrainerName();

            Charmander charmander = new Charmander("Charmander");
            Bulbasaur bulbasaur = new Bulbasaur("Bulbasaur");
            Squirtle squirtle = new Squirtle("Squirtle");

            
            for (int charm = 0; charm < 2; charm++)
            { 
                trainer.AddToBelt(new Pokeball(charmander, true, true));
                trainer2.AddToBelt(new Pokeball(charmander, true, true));
            }
            for (int bulb = 0; bulb < 2; bulb++)
            {
                trainer.AddToBelt(new Pokeball(bulbasaur, true, true)); 
                trainer2.AddToBelt(new Pokeball(bulbasaur, true, true));
            }
            for (int squirt = 0; squirt < 2; squirt++)
            {
                trainer.AddToBelt(new Pokeball(squirtle, true, true));
                trainer2.AddToBelt(new Pokeball(squirtle, true, true));
            }
            
            for (int ballNumber = 0; ballNumber < 6; ballNumber++)
            {
                //Pokemon beestje = trainer.throwPokeball();
                trainer.belt[ballNumber].ThrowPokemon(trainer.name);
                trainer.belt[ballNumber].pokemonDetails.battleCry(); 
                trainer2.belt[ballNumber].ThrowPokemon(trainer2.name);
                trainer.belt[ballNumber].pokemonDetails.battleCry();
                trainer.belt[ballNumber].RecallPokemon(trainer.name);
                trainer2.belt[ballNumber].RecallPokemon(trainer2.name);
            }
            game = Pokemon.continueGame();
        }
        //
        //There are restrictions to the Pokemon class and its subclasses:
            //1. The subclasses must make use of the parent constructor of the Pokemon class.
            //2. The battle cry must be an abstract method in the Pokemon class.
            //check pokemon class 



















        //3.The player gives a name to the second trainer.
        //Trainer player2 = new Trainer("player2");
        //player2.setTrainerName();

        //for(int i = 0; i < 6; i++)
        //{ 
        //    player2.setBelt();
        //}
        //while ()
        //{
        //4.The first trainer throws the first pokeball on its belt
        //5.The pokeball released the charmander and charmander does its battle cry.
        //6.The second trainer throws the first pokeball on its belt.
        //7.The pokeball released the charmander and charmander does its battle cry.
        //8.The first trainer returns the charmander back to its pokeball.
        //9.The second trainer returns the charmander back to its pokeball.
        //}

        //10.Repeat 4 to 9 until all pokeballs have been used by both trainers.









        //Assignment 1
        //=================================================================================================
        //Pokemon charmander = new Pokemon("charmander", "fire", "water");
        //// 2. The player gives a name to a charmander.
        //charmander.rename();

        //// 3. The charmander does its battle cry for ten times.
        //charmander.battleCry();


        //// 6. Repeat 4 and 5 until the player quits the game.
        //while (true) 
        //{   
        //    // 4. The player can give a new name to the same charmander.
        //    charmander.rename();

        //    // 5. The charmander does its battle cry for ten times.
        //    charmander.battleCry();
        //}
        //=================================================================================================

    }
}