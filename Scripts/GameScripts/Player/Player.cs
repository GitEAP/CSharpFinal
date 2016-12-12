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
    public int weaponNumber2;
    public static List<string> weaponInventory = new List<string>();
    public static List<string> foodInventory = new List<string>();
    public static List<string> itemInventory = new List<string>();
    Random randomNum = new Random();
    public string foundItem;
    public string userItem;

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
    //when new weapon is found it adds it to the players inventory.
    public void findWeapons()
    {
        Console.WriteLine("my weapons " + weaponInventory);
        foundItem = useableWeapons.arrayOfWeapons[randomNum.Next(0, useableWeapons.arrayOfWeapons.Length)];//gets a random weapon from useable weapons
        Console.WriteLine("You found a " + foundItem);
        vikingPlayer.weaponInventory.Add(foundItem);
    }
    public void assignWeapon(int weaponNumber)
    {
        weaponEquiped = useableWeapons.arrayOfWeapons[weaponNumber];
        weaponDamage = randomNum.Next(1, 50);
    }
    public int getWeaponNumber(string weapon)
    {
        switch (weapon)
        {
            case "sword":
                weaponNumber2 = 0;
                break;
            case "spear":
                weaponNumber2 = 1;
                break;
            case "bow":
                weaponNumber2 = 2;
                break;
            case "axe":
                weaponNumber2 = 3;
                break;
            case "two handed axe":
                weaponNumber2 = 4;
                break;
        }
        return weaponNumber2;
    }
    public void eatFood()
    {
        foodInventory.Remove(Console.ReadLine());
        health += 20;
        if (health > 100)
        {
            health = 100;
        }
    }
    public void displayItems()
    {
        foreach (string item in itemInventory)
        {
            Console.WriteLine(item);
        }
    }
    public string getItem()
    {
        Console.WriteLine("Which Item do you want to use");
        userItem = Console.ReadLine();
        itemInventory.Remove(userItem);
        return userItem;
    }
    public void findFood()
    {
        foundItem = useableFood.arrayOfFood[randomNum.Next(0, useableFood.arrayOfFood.Length)];//gets a random weapon from useable weapons
        Console.WriteLine("You found " + foundItem);
        vikingPlayer.foodInventory.Add(foundItem);
    }
    public void findItem()
    {
        foundItem = useableItems.arrayOfItems[randomNum.Next(0, useableItems.arrayOfItems.Length)];//gets a random weapon from useable weapons
        Console.WriteLine("You found " + foundItem);
        vikingPlayer.itemInventory.Add(foundItem);
    }
}



//Random number
//Random random = new Random();
//item.strength = random.Next(5, 10);