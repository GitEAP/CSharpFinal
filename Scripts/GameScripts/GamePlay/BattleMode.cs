using System;
using System.Collections.Generic;
public class BattleMode
{
    public string myChoice;
    Random randomNum = new Random();
    public int theOdds;

    public  Enemie OgreEnemies = new Ogre();//Makes a new ogre enemy.

    public static List<Enemie> Ogres;

    public BattleMode()
    {
        for (int i = 0; i < 5; i++)
        {
            Ogres.Add(OgreEnemies);
        }
    }


    public void Encounter(int i)
    {
        switch (i)
        {
            case 0:
                Console.WriteLine("You have encounter an Ogre");
                Console.WriteLine(" the ogre has a " + Ogres[0].weaponEquiped);
                // while (Ogre.health > 0 || Game.vikingPlayer.health > 0)
                // {
                //     battle();
                // }
                break;
            default:
                Console.WriteLine("You encounter nothing");
                break;
        }
    }

    public void battle()
    {
        theOdds = randomNum.Next(0, 1);

        Console.WriteLine("The enemy has a " + Ogre.weaponEquiped);

        Console.WriteLine("Will you attack or run away");
        myChoice = Console.ReadLine();

        if (myChoice == "attack")
        {
            if (theOdds == 0)
            {
                Ogre.health -= 5;
                Console.WriteLine("You attacked the Ogre.");
            }
            else if (theOdds == 1)
            {
               Game.vikingPlayer.health -= Ogre.weaponDamage;
                Console.WriteLine("The Ogre attacked you. You lost " + Ogre.weaponDamage + " of health");//gives feedback on the damage done.
               Console.WriteLine("you have " + Game.vikingPlayer.health + " of Health");//displays the players total health

            }
        }
        else if (myChoice == "run away" || myChoice == "run")
        {
            Console.WriteLine("You ran away");
        }
    }
}