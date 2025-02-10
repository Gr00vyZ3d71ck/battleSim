class Pokemon
{
    private string name;
    private string type;
    private string weakness;
 
    public Pokemon(string name, string type, string weakness)
    {
        this.name = name;
        this.type = type;
        this.weakness = weakness;
    }

    public string gettype()
    {
        return this.type;
    }

    public string getName()
    {
        return this.name;
    }

    public void showStats()
    {
        Console.WriteLine(this.name);
        Console.WriteLine(this.type);
        Console.WriteLine(this.weakness);
    }
}