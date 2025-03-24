using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class Battle

{
    public Trainer trainer;
    public Trainer trainer2;

    public Pokeball LastChosenPokemonTrainer1;
    public Pokeball LastChosenPokemonTrainer2;

    public string lastResult;


    public Battle(Trainer trainer, Trainer trainer2)
    {
        this.trainer = trainer;
        this.trainer2 = trainer2;

    }

    // public bool CheckBattlePosibility() 
    // {

    //     foreach(Pokeball ball in this.trainer.belt)
    //     {
    //         BattleCheck(ball)
    //     }
    // }

    public string BattleActions(int round)
    {

        //Eerste ronde pakken beide trainers een nieuwe pokemon van de belt.
        if (trainer.lastMatchWon == true)
        {

            Pokeball ChosenPokemonFromTrainer2 = this.trainer2.GrabFromBelt();
            LastChosenPokemonTrainer2 = ChosenPokemonFromTrainer2;

            this.trainer.ThrowPokeball(LastChosenPokemonTrainer1);

            this.trainer2.ThrowPokeball(ChosenPokemonFromTrainer2);

            return BattleCheck(LastChosenPokemonTrainer1, ChosenPokemonFromTrainer2);
        }
        else if (trainer2.lastMatchWon == true)
        {

            Pokeball ChosenPokemonFromTrainer1 = this.trainer.GrabFromBelt();

            LastChosenPokemonTrainer1 = ChosenPokemonFromTrainer1;


            this.trainer.ThrowPokeball(ChosenPokemonFromTrainer1);

            this.trainer2.ThrowPokeball(LastChosenPokemonTrainer2);

            return BattleCheck(ChosenPokemonFromTrainer1, LastChosenPokemonTrainer2);
        }
        else if (lastResult == "draw" && round > 1)
        {
            if (trainer.lastMatchWon == true)
            {
                Pokeball ChosenPokemonFromTrainer2 = this.trainer2.GrabFromBelt();
                LastChosenPokemonTrainer2 = ChosenPokemonFromTrainer2;

                this.trainer.ThrowPokeball(LastChosenPokemonTrainer1);
                this.trainer.ThrowPokeball(ChosenPokemonFromTrainer2);



                return BattleCheck(LastChosenPokemonTrainer1, ChosenPokemonFromTrainer2);
            }
            else if (trainer2.lastMatchWon == true)
            {
                Pokeball ChosenPokemonFromTrainer1 = this.trainer.GrabFromBelt();
                LastChosenPokemonTrainer1 = ChosenPokemonFromTrainer1;



                return BattleCheck(ChosenPokemonFromTrainer1, LastChosenPokemonTrainer2);
            }
            else
            {
                Pokeball ChosenPokemonFromTrainer1 = this.trainer.GrabFromBelt();
                this.trainer.ThrowPokeball(ChosenPokemonFromTrainer1);

                Pokeball ChosenPokemonFromTrainer2 = this.trainer2.GrabFromBelt();
                this.trainer2.ThrowPokeball(ChosenPokemonFromTrainer2);

                LastChosenPokemonTrainer1 = ChosenPokemonFromTrainer1;
                LastChosenPokemonTrainer2 = ChosenPokemonFromTrainer2;

                return BattleCheck(ChosenPokemonFromTrainer1, ChosenPokemonFromTrainer2);
            }
        }
        else
        {
            Console.WriteLine("--==Dit is ronde 1==--");
            Pokeball ChosenPokemonFromTrainer1 = this.trainer.GrabFromBelt();
            this.trainer.ThrowPokeball(ChosenPokemonFromTrainer1);

            Pokeball ChosenPokemonFromTrainer2 = this.trainer2.GrabFromBelt();
            this.trainer2.ThrowPokeball(ChosenPokemonFromTrainer2);

            LastChosenPokemonTrainer1 = ChosenPokemonFromTrainer1;
            LastChosenPokemonTrainer2 = ChosenPokemonFromTrainer2;

            return BattleCheck(ChosenPokemonFromTrainer1, ChosenPokemonFromTrainer2);
        }

    }



    public string BattleCheck(Pokeball ChosenPokemonFromTrainer1, Pokeball ChosenPokemonFromTrainer2)
    {
        if (ChosenPokemonFromTrainer1.pokemonDetails.weakness == ChosenPokemonFromTrainer2.pokemonDetails.type) //player 2 wins
        {
            Console.WriteLine($"{ChosenPokemonFromTrainer2.pokemonDetails.name} defeated {ChosenPokemonFromTrainer1.pokemonDetails.name}");
            ChosenPokemonFromTrainer1.pokemonDetails.isFainted = true;
            Console.WriteLine($"{ChosenPokemonFromTrainer1.pokemonDetails.name} has fainted");
            trainer2.lastMatchWon = true;
            trainer.lastMatchWon = false;
            lastResult = "trainer2";
            return lastResult;
        }
        else if (ChosenPokemonFromTrainer2.pokemonDetails.weakness == ChosenPokemonFromTrainer1.pokemonDetails.type) //player 1 wins
        {
            Console.WriteLine($"{ChosenPokemonFromTrainer1.pokemonDetails.name} defeated {ChosenPokemonFromTrainer2.pokemonDetails.name}");
            ChosenPokemonFromTrainer2.pokemonDetails.isFainted = true;
            Console.WriteLine($"{ChosenPokemonFromTrainer2.pokemonDetails.name} has fainted");

            trainer.lastMatchWon = true;
            trainer2.lastMatchWon = false;
            lastResult = "trainer1";
            return lastResult;
        }
        else
        {

            lastResult = "draw";
            return lastResult;
        }
    }
}
// public void DrawSequence(Pokeball ChosenPokemonFromTrainer1, Pokeball ChosenPokemonFromTrainer2){
//     BattleCheck(this.trainer.GrabFromBelt(), this.trainer2.GrabFromBelt());
// }