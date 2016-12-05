using System;
public class Player
{
    //What each player needs.
    public int health;
    public int armor;
    public string weaponEquiped;
    public int weaponDamage;
    public string[] weaponInventory;
    public string[] foodInventory;
    public string[] itemInventory;
    
    private string WelcomePlayer(string _name)
    {
        return "Hello " + _name;
    }

    public void GetName()
    {
        Console.WriteLine("What is your name?");
        string myString = WelcomePlayer(Console.ReadLine());
        Console.WriteLine(myString);
    }
}

//Random number
//Random random = new Random();
//item.strength = random.Next(5, 10);