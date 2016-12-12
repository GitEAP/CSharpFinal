using System;
using System.Collections.Generic;

public class Player
{
        public static Inventories useableWeapons = new Inventories();//Inventory of useableWeapons for player.
    public static Inventories useableItems = new Inventories();//Inventory useableItems for player.
    public static Inventories useableFood = new Inventories();//Inventory useableFood for player.
    //What the player needs.
    public int health;
    public int armor;
    public string weaponEquiped;
    public int weaponDamage;
    public static List<string> weaponInventory;
    public static List<string> foodInventory;
    public static List<string> itemInventory;
    Random randomNum = new Random();
    public string foundItem;
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
    
    public void displayWeapons()
    {
        foreach (string weapon in weaponInventory)
        {
            Console.WriteLine(weapon);
        }
    }

    internal void findWeapons()
    {
        foundItem = useableWeapons.arrayOfWeapons[randomNum.Next(0, useableWeapons.arrayOfWeapons.Length)];//gets a random weapon from useable weapons
        weaponInventory.Add(foundItem);
        Console.WriteLine("You found a " + foundItem);
    }
}


//Random number
//Random random = new Random();
//item.strength = random.Next(5, 10);