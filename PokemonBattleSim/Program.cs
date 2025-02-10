using System;
using System.Runtime.CompilerServices;



class Test 
{
    static void Main()
    {
        Pokemon charmander = new Pokemon("charmander", "fire", "water");

        // 2. The player gives a name to a charmander.
        charmander.rename();

        // 3. The charmander does its battle cry for ten times.
        charmander.battleCry();

        // 4. The player can give a new name to the same charmander.
        charmander.rename();

        // 5. The charmander does its battle cry for ten times.
        charmander.battleCry();
    }
}