using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Trainer
{
    public string name;
    public string pokemon;
    public List<Pokeball> belt = new List<Pokeball>();


    public Trainer(string name)
    {
        this.name = name;
        this.belt = new List<Pokeball>();
    }

    public void AddToBelt(Pokeball ball)
    {
        this.belt.Add(ball);
    }

    public void ShowBelt()
    {
        foreach (Pokeball ball in belt)
        {
            ball.ShowStats();
        }
    }


    public void setTrainerName()
    {
        try
        {
            Console.WriteLine($"What name do you want {this.name} to have?");
            this.name = Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    

    //public List<Pokeball> setBelt()
    //{
    //    setBelt test = new 
    //}
    



}

