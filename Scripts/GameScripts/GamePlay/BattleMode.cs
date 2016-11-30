using System;
public class BattleMode
{


    public string myChoice;
    public static Enemie Ogre = new Ogre();//Makes a new ogre enemy.


    public void Encounter(int i)
    {
        switch (i)
        {
            case 0:
                Console.WriteLine("You have encounter an Ogre");
              Console.WriteLine("The enemy has " + Ogre.weaponEquiped);

                battle();
                break;
            default:
                Console.WriteLine("You encounter nothing");
                break;
        }

    }
    public void battle()
    {
        Console.WriteLine("The enemy has " + Ogre.weaponEquiped);
        Console.WriteLine("Will you attack or run away");
        myChoice = Console.ReadLine();
        if (myChoice == "attack")
        {
            Ogre.health -= 5;
            Console.WriteLine("You attacked the Ogre.");
        }
        else if (myChoice == "run away" || myChoice == "run")
        {
            Console.WriteLine("You ran away");
        }
    }

}