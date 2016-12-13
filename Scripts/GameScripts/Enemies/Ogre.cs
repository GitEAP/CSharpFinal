using System;

public class Ogre : Enemie
{
    Random randomNum = new Random();
    public static Inventories weapon = new Inventories();//Makes a new enemie.


    public Ogre()
    {
        health = 100;
        armor = 10;
        weaponEquiped = weapon.arrayOfWeapons[randomNum.Next(0, (weapon.arrayOfWeapons.Length -1) )];// get random weapon from Inventories.cs
        weaponDamage = randomNum.Next(10, 20);
    }
}

