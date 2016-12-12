using System;
public class Game
{
    public static Player vikingPlayer = new vikingPlayer();//Makes a new player.
    public static BattleMode battle = new BattleMode();
    public static string myDirection;
    public int theOdds;
    public string item;
    public int chooseWeapon;
    Random randomNum = new Random();

    public void Start()
    {
        while (vikingPlayer.health > 0)
        {
            Play();
        }
        if (vikingPlayer.health == 0)
        {
            Console.WriteLine("Game Over");
        }
    }

    public Game()
    {
        Console.WriteLine("Game will now Start");
        vikingPlayer.GetName();//gets players name.
        Console.WriteLine("you walk inside the house");
    }
    //will start playing game.
    public void Play()
    {
        chooseDirection();
        Console.WriteLine("What weapon will you choose");
        vikingPlayer.displayWeapons();
        //converts the string to an int. Assigns the weapon to the player.
        chooseWeapon = vikingPlayer.getWeaponNumber(Console.ReadLine());
        vikingPlayer.assignWeapon(chooseWeapon);
        Console.WriteLine("You are using a " + vikingPlayer.weaponEquiped);
        battle.Encounter(randomNum.Next(0, 2));
    }//closes Play
    public void chooseDirection()
    {
        Console.WriteLine("Which direction would you like to go: north, west, east, south");
        myDirection = Console.ReadLine();
        switch (myDirection)
        {
            case "north":
                Console.WriteLine("Do you want to check the chest, skeleton, or rock");
                item = Console.ReadLine();
                oddsOfFinding();
                break;
            case "west":
                Console.WriteLine("Do you want to check the chest, skeleton, or rock");
                item = Console.ReadLine();
                oddsOfFinding();
                break;
            case "east":
                Console.WriteLine("Do you want to check the chest, skeleton, or rock");
                item = Console.ReadLine();
                oddsOfFinding();
                break;
            case "south":
                Console.WriteLine("Do you want to check the chest, skeleton, or rock");
                item = Console.ReadLine();
                oddsOfFinding();
                break;
            default:
                Console.WriteLine("Not a valid command");
               chooseDirection();
                break;
        }
    }

    public void oddsOfFinding()
    {
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
        oddsOfFindingFood();
        oddsOfFindingItems();
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






