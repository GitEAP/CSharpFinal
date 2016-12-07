using System;
using System.Collections.Generic;

public class Player
{
    //What the player needs.
    public int health;
    public int armor;
    public string weaponEquiped;
    public int weaponDamage;
    public static List<string> weaponInventory;
    public static List<string> foodInventory;
    public static List<string> itemInventory;

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