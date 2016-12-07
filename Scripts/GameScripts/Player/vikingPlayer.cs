using System;
using System.Collections.Generic;
public class vikingPlayer : Player
{
    public static Inventories useableWeapons = new Inventories();//Inventory of useableWeapons for player.
    public static Inventories useableItems = new Inventories();//Inventory useableItems for player.
    public static Inventories useableFood = new Inventories();//Inventory useableFood for player.
    Random randomNum = new Random();


    public vikingPlayer()
    {
        health = 100;
        armor = randomNum.Next(1, 50);

        weaponEquiped = useableWeapons.arrayOfWeapons[randomNum.Next(0, useableWeapons.arrayOfWeapons.Length)];
        weaponDamage = randomNum.Next(1, 50);

        // weaponInventory.Add(useableWeapons.arrayOfWeapons[randomNum.Next(0, useableWeapons.arrayOfWeapons.Length)]);
        // foodInventory.Add(useableFood.arrayOfFood[randomNum.Next(0, useableWeapons.arrayOfFood.Length)]);
        // itemInventory.Add(useableItems.arrayOfItems[randomNum.Next(0, useableWeapons.arrayOfItems.Length)]);
    }


}