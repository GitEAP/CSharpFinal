using System.Collections.Generic;
using System;
public class pWeaponInventory
{
    //List
    public List<string> listOfWeapons;

    //Array
    // public string[] arrayOfWeapons = {"Gun", "Knife", "Bow"};

    public void RunList()
    {
        listOfWeapons = new List<string>();//turned into an object
        ChangeList();
    }

    private void ChangeList()
    {
        Console.WriteLine(listOfWeapons.Count);

        foreach (string weapon in listOfWeapons)
        {
            Console.WriteLine(weapon);
        }

        listOfWeapons.Add(Console.ReadLine());//.Add(new Weapon);//for object lists

        if (listOfWeapons.Count >= 3)
        {
            ChangeList();
        }
    }
}