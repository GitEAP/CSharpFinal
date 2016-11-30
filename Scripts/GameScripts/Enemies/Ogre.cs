using System;

public class Ogre : Enemie
{
    public static Enemie ogreEnemie = new Enemie();//Makes a new enemie.
    Random randomNum = new Random();
    public static Inventories weapon = new Inventories();//Makes a new enemie.


    public Ogre()
    {
        ogreEnemie.health = 100;
        ogreEnemie.armor = 10;
        ogreEnemie.weaponEquiped = weapon.arrayOfWeapons[randomNum.Next(0, (weapon.arrayOfWeapons.Length -1) )];// get random weapon from Inventories.cs
        ogreEnemie.weaponDamage = 7;
        
    }
}

