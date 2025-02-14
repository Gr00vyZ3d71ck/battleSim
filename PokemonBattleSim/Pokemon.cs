class Pokemon
{
    public string name;
    public string pokemon;
    public string type;
    public string weakness;


    public Pokemon(string name,string type,string weakness)
    {
        this.pokemon = name;
        this.name = name;
        this.type = type;
        this.weakness = weakness;
    }

    public void rename()
    {
        Console.WriteLine($"Rename your {this.pokemon} ({this.name})");
        this.name = Console.ReadLine();
    }
    
    public void battleCry()
    {
        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine($"{this.pokemon} Says: '{this.name}'");
        }
    }
    public string getName()
    {
        return this.name;
    }

    //public void showStats()
    //{
    //    Console.WriteLine($"Name: {this.name}");
    //    Console.WriteLine($"Type: {this.type}");
    //    Console.WriteLine($"Weakness: {this.weakness}");
    //}
}