using System;
using System.Collections.Generic;
public class BattleMode
{
    public string myChoice;
    Random randomNum = new Random();
    public int theOdds;

    public Enemie Ogre1 = new Ogre();//Makes a new ogre enemy.

    // public static List<Enemie> Ogres;
    // public BattleMode()
    // {
    //     for (int i = 0; i < 5; i++)
    //     {
    //         Ogres.Add(Ogre);
    //     }
    // }





    public void Encounter(int i)
    {
        switch (i)
        {
            case 0:
                Console.WriteLine("You have encounter an Ogre");
                Console.WriteLine("The Ogre has a " + Ogre1.weaponEquiped);
                // Console.WriteLine("The enemy has a " + Ogre1.weaponEquiped);

                while (Ogre1.health > 0 || Game.vikingPlayer.health > 0)
                {
                    Random randomNum = new Random();
                    battle();
                }
                break;
            default:
                Console.WriteLine("You encounter nothing");
                break;
        }
    }

    public void battle()
    {

        theOdds = randomNum.Next(0, 2);

        Console.WriteLine("Will you attack or run away");
        myChoice = Console.ReadLine();

        if (myChoice == "attack")
        {
            if (theOdds == 0)
            {
                Ogre1.health -= 25;
                Console.WriteLine("You attacked the Ogre.");
                Console.WriteLine("Enemy has " + Ogre1.health + " of Health");//displays the players total health
            }
            else if (theOdds == 1)
            {
                Game.vikingPlayer.health -= Ogre1.weaponDamage;
                Console.WriteLine("The Ogre attacked you. You lost " + Ogre1.weaponDamage + " of health");//gives feedback on the damage done.
                Console.WriteLine("you have " + Game.vikingPlayer.health + " of Health");//displays the players total health

            }
        }
        else if (myChoice == "run away" || myChoice == "run")
        {
            Console.WriteLine("You ran away");
        }
    }
}