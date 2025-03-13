using System;
using System.Collections.Generic;
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
        while (true)
        {
            //
            Battle theBattle = new Battle(this.trainer, this.trainer2);
            theBattle.BattleActions();

        }
        //Console.WriteLine($"Trainer{} Heeft gewonnen");
    }

    // public bool CheckFainted()
    // {
    //     foreach(Pokemon )

    // }


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





}