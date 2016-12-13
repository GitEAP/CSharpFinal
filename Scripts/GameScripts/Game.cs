using System;
public class Game
{
    public static Player vikingPlayer = new vikingPlayer();//Makes a new player.
    public static BattleMode battle = new BattleMode();
    public static LevelBase cave = new CaveLevel();
    public static string myDirection;
    public int theOdds;
    public bool weaponCount = true;

    public string item;
    Random randomNum = new Random();

    public void Start()
    {
        while (vikingPlayer.health > 0)
        {
            Play();
        }
        if (vikingPlayer.health <= 0)
        {
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("The enemy killed you.");
            Console.WriteLine("Game Over");
        }
    }
    public Game()
    {
        Console.WriteLine("It is the year 837 CE. It is that Viking age. You live in a small town in Scandinavia. In the recent months the town has been attacked by monsters. Until known you have not been affected.");
        vikingPlayer.GetName();//gets players name.
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("You live with your father in a farm. You earn your living by raising livestock. This has been a hard year for you. Your family does not have any more money. Your father was going to sell the only pig you owned but one of the monsters stole your pig. You decided to go out and find your pig. ");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("Before you leave for your adventure your father gave you an armor set that used to be your grandfathers.");
        Console.WriteLine("You now have: " + vikingPlayer.armor + "% of armor.");
        Console.WriteLine("Now you need to find a weapon for your adventure.");
        Console.WriteLine("The next morning you leave for your adventure.");
        Console.WriteLine("A few hours later you arrive at a cave. You see pig tracks going inside the cave. You decide to go inside the cave.");
        Console.WriteLine("******************************************************************************");
    }
    //will start playing game.
    public void Play()
    {
        chooseDirection();
        oddsOfFindingFood();
        oddsOfFindingItems();

        theOdds = randomNum.Next(0, 2);
        if (theOdds == 0)
        {//encounter ogre
            battle.Encounter(randomNum.Next(0, 2), new Ogre());
        }
        else
        {//encounter dwarf
            battle.Encounter(randomNum.Next(0, 2), new Dwarf());
        }
    }//closes Play
    public void chooseDirection()
    {
        Console.WriteLine("Which direction would you like to go: north, west, east, south");
        myDirection = Console.ReadLine();
        switch (myDirection)
        {
            case "north":
                getCaveItems(0);
                oddsOfFinding();
                break;
            case "west":
                getCaveItems(0);
                oddsOfFinding();
                break;
            case "east":
                getCaveItems(cave.itemsAvailable.Length / 2);
                oddsOfFinding();
                break;
            case "south":
                getCaveItems(cave.itemsAvailable.Length / 2);
                oddsOfFinding();
                break;
            default:
                Console.WriteLine("Not a valid command");
                chooseDirection();
                break;
        }
        //runs this code if the player does not have at least one weapon
        //it avoids an exception later on.
        weaponCount = vikingPlayer.checkWeapons();
        if (weaponCount == false)//if there are 0 weapons in inventory.
        {
            chooseDirection();
        }
    }//closes chooseDirection

    public void oddsOfFinding()
    {
        Console.WriteLine("******************************************************************************");
        theOdds = randomNum.Next(0, 2);
        switch (theOdds)
        {
            case 0:
                vikingPlayer.findWeapons();
                break;
            default:
                Console.WriteLine("You did not find a weapon in the " + item);
                break;
        }//closes switch
    }
    public void oddsOfFindingFood()
    {
        theOdds = randomNum.Next(0, 2);
        switch (theOdds)
        {
            case 0:
                vikingPlayer.findFood();
                break;
            default:
                break;
        }//closes switch
    }
    public void oddsOfFindingItems()
    {
        theOdds = randomNum.Next(0, 2);
        switch (theOdds)
        {
            case 0:
                vikingPlayer.findItem();
                break;
            default:
                Console.WriteLine("You did not find anything else");
                break;
        }//closes switch
    }
    public void getCaveItems(int j)
    {
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("You found a couple of objects in this area that you can check for stuff.");
        Console.WriteLine("They are: ");
        if (j == 0)
        {
            for (int i = j; i < (cave.itemsAvailable.Length / 2); i++)
            {
                Console.WriteLine(cave.itemsAvailable[i]);
            }
        }
        else if (j == 3)
        {
            for (int i = j; i < cave.itemsAvailable.Length; i++)
            {
                Console.WriteLine(cave.itemsAvailable[i]);
            }
        }
        Console.WriteLine("What do you want to check?(type the name of the object)");
        item = Console.ReadLine();
    }
}
// Game
// make new player
// make new enemies
// make new weapons 
// make new items
// make new food items


// Game needs
// a player
// levels and areas in levels
// inventory for weapons, food, items
// things in areas to find items for inventory.
// directions North, South, East, West
// enemies
// battlemode
// food for health regeneration
// (optional) player enters a shop as a location
// (optional) randomlly. player chooses to trade items to repair armor or get food or upgrade weapon.


// intro to game
// player loses pig
// player needs to find pig
// player receive random weapons
// player receive random armor set
// player leaves house and decides which direction to go.
// player will enter random location from a set amount of locations
// player chooses to search around or go to next area
// repeat until you find enemie(s) 
// player chooses weapon from inventory
// player enters battle mode with enemie
// player can access food to gain health.
// after battle mode player chooses new direction to go and repeat
// repeat until player finds lost pig

//notes
//Random number
//Random random = new Random();
//item.strength = random.next(5, 10);






