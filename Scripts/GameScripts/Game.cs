using System;
public class Game
{
    public static Player vikingPlayer = new vikingPlayer();//Makes a new player.
    public static BattleMode battle = new BattleMode();
    public static string myDirection;


    //will make things for the game ie: player enemies items etc.
    //will start playing game.
    public void Play()
    {
        Console.WriteLine("Game will now Start");
        vikingPlayer.GetName();

        Console.WriteLine("you walk inside the house");

        Console.WriteLine("Which direction would you like to go: north, west, east, south");
        myDirection = Console.ReadLine();
        Random randomNum = new Random();
        vikingPlayer.health = 100;

        if (myDirection == "north")
        {
            battle.Encounter(randomNum.Next(0, 1));
        }
        else if (myDirection == "west")
        {
            battle.Encounter(randomNum.Next(0, 1));
        }
        else if (myDirection == "east")
        {

        }
        else if (myDirection == "south")
        {

        }
        else
        {

        }
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






