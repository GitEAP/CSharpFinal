using System;
public class Dwarf : Enemie
{
    Random randomNum = new Random();
    public static Inventories weapon = new Inventories();//Makes a new enemie.

    public Dwarf()
    {
        health = 100;
        armor = 10;
        weaponEquiped = weapon.arrayOfWeapons[randomNum.Next(0, (weapon.arrayOfWeapons.Length - 1))];// get random weapon from Inventories.cs
        weaponDamage = randomNum.Next(25, 35);
    }
}

