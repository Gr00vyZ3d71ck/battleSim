using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Arena
{
    public static int scoreTrainer1 = 0;
    public static int scoreTrainer2 = 0;

    public Trainer trainer;
    public Trainer trainer2;

    public Arena(Trainer trainer, Trainer trainer2)
    {
        this.trainer = trainer;
        this.trainer2 = trainer2;
    }

    public void InitiateBattle()
    {
        bool ContinuePlaying = true;
        int roundNumber = 0;
        Battle theBattle = new Battle(this.trainer, this.trainer2);
        while (ContinuePlaying)
        {
            roundNumber += 1;
            Console.WriteLine($"----------=Round:{roundNumber}");
            ContinuePlaying = CheckFainted();

            // System.Threading.Thread.Sleep(500);
            IncrementScore(theBattle.BattleActions(roundNumber));
            // System.Threading.Thread.Sleep(500);
        }
    }



    public bool CheckFainted()
    {
        int FaintedBallCountTrainer1 = 0;
        int FaintedBallCountTrainer2 = 0;

        foreach (Pokeball ball in this.trainer.belt)
        {
            if (ball.pokemonDetails.isFainted == true)
            {

                FaintedBallCountTrainer1 += 1;
                if (FaintedBallCountTrainer1 == 6)
                {
                    Console.WriteLine(ShowResult(scoreTrainer1, scoreTrainer2));
                    return false;
                }
            }
        }

        foreach (Pokeball ball2 in this.trainer2.belt)
        {

            if (ball2.pokemonDetails.isFainted == true)
            {
                FaintedBallCountTrainer2 += 1;
                if (FaintedBallCountTrainer2 == 6)
                {

                    Console.WriteLine(ShowResult(scoreTrainer1, scoreTrainer2));
                    return false;

                }
            }
        }
        return true;
    }
    public static string ShowResult(int scoreTrainer1, int scoreTrainer2)
    {
        if (scoreTrainer1 > scoreTrainer2)
        {
            return $"Trainer1 heeft gewonnen met een score van {scoreTrainer1}. ";
        }
        else if (scoreTrainer1 < scoreTrainer2)
        {
            return $"Trainer2 heeft gewonnen met een score van {scoreTrainer2}. ";
        }
        else
        {
            return $"Het spel is geëindigt in een gelijkspel. ";
        }
    }

    public static void IncrementScore(string result)
    {
        if (result == "trainer1")
        {
            scoreTrainer1 += 1;

            // player1.wonLastRound = true
            // player2.wonLastRound = false (voorbeeld)
        }
        if (result == "trainer2")
        {
            scoreTrainer2 += 1;
        }
    }



    // public bool CheckFainted()
    // {
    //     int trainer1alive = 0;
    //     int trainer2fainted = 0;
    //     foreach(Pokeball ball1 in this.trainer.belt)
    //     {

    //         if(ball1.pokemonDetails.isFainted == true)
    //         {
    //             return ball1.pokemonDetails.isFainted;
    //         }
    //         else
    //         {
    //             trainer1alive += 1;
    //             return ball1.pokemonDetails.isFainted;
    //         }
    //     }
    //     foreach(Pokeball ball2 in this.trainer2.belt)
    //     {

    //         if(ball2.pokemonDetails.isFainted == true)
    //         {
    //             return ball2.pokemonDetails.isFainted;
    //         }
    //         else
    //         {
    //             return ball2.pokemonDetails.isFainted;
    //         }
    //     }
    //     return false;

    // }


    // public string CheckWinner()
    // {
    //     foreach(Pokeball ball in this.trainer.belt)
    //     {

    //     }
    // }








}