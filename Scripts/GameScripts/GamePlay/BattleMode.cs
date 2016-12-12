using System;
using System.Collections.Generic;
public class BattleMode
{
    public string myChoice;
    Random randomNum = new Random();
    public int theOdds;
    public string useableItem;

    public Enemie Ogre1 = new Ogre();//Makes a new ogre enemy.
    //public Enemie Dwarf1 = new Dwarf();//Makes a new Dwarf enemy.

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


                while (Ogre1.health > 0 || Game.vikingPlayer.health > 0)
                {
                    if (myChoice == "run" || myChoice == "run away")
                    {
                        break;
                    }
                    else if (Ogre1.health <= 0)
                    {
                        Console.WriteLine("You killed the enemy");
                        break;
                    }
                    else if (Game.vikingPlayer.health <= 0)
                    {
                        Console.WriteLine("The enemy killed you");
                        break;
                    }
                    else
                    {
                        Random randomNum = new Random();
                        battle();
                    }
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

        Console.WriteLine("Will you 'attack', 'run away', 'eat' food, use 'item'");
        myChoice = Console.ReadLine();

        if (myChoice == "attack")
        {
            if (theOdds == 0)
            {
                Ogre1.health -= Game.vikingPlayer.weaponDamage;
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
        else if (myChoice == "eat")
        {
            Game.vikingPlayer.eatFood();
        }
        else if (myChoice == "item")
        {
            Game.vikingPlayer.displayItems();
            useableItem = Game.vikingPlayer.getItem();
            
            if (theOdds == 0)
            {
                Ogre1.health -= Game.vikingPlayer.weaponDamage;
                Console.WriteLine("The enemy did not want your " + useableItem);
                Console.WriteLine("The Ogre attacked you. You lost " + Ogre1.weaponDamage + " of health");//gives feedback on the damage done.
                Console.WriteLine("you have " + Game.vikingPlayer.health + " of Health");//displays the players total health
            }
            else if (theOdds == 1)
            {
                Console.WriteLine("the enemy accepted the " + useableItem + "It made the enemy weaker");//gives feedback on the damage done.
                Ogre1.weaponDamage = 15;
            }
        }
        else
        {
            Console.WriteLine("Not a valid command");
        }
    }//closes battle()
}