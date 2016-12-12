using System;
public class vikingPlayer : Player
{

    Random randomNum = new Random();

    public vikingPlayer()
    {
        health = 100;
        armor = randomNum.Next(1, 50);

        // weaponInventory.Add(useableWeapons.arrayOfWeapons[randomNum.Next(0, useableWeapons.arrayOfWeapons.Length)]);
        // foodInventory.Add(useableFood.arrayOfFood[randomNum.Next(0, useableWeapons.arrayOfFood.Length)]);
        // itemInventory.Add(useableItems.arrayOfItems[randomNum.Next(0, useableWeapons.arrayOfItems.Length)]);
    }

}