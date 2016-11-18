using System;
public class Player
{
    //What each player needs.
    public int health = 100;
    public int armor = 0;
    public string weaponEquiped;
    public int weaponDamage;
    public string[] weaponInventory;
    public string[] foodInventory;
    public string[] itemInventory;


    //constructor for Player
    public Player()
    {




    }






    public string WelcomePlayer(string _name)
    {
        return "Hello " + _name;
    }

    public void GetName()
    {
        Console.WriteLine("Hello World. What is your name?");
        string myString = WelcomePlayer(Console.ReadLine());
        Console.WriteLine(myString);

        if (myString == " ")
        {
            Console.WriteLine("What is your name?");
            myString = WelcomePlayer(Console.ReadLine());
            Console.WriteLine(myString);
        }
        else
        {
            //Play();
        }
    }

}

//Random number
//Random random = new Random();
//item.strength = random.next(5, 10);