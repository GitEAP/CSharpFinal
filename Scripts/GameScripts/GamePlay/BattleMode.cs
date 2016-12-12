using System;
public class BattleMode
{
    public string myChoice;
    Random randomNum = new Random();
    public int theOdds;
    public string useableItem;

    public void Encounter(int i, Enemie enemy)
    {
        switch (i)
        {
            case 0:
                Console.WriteLine("You have encounter an " + enemy);
                Console.WriteLine("The " +enemy+ " has a " + enemy.weaponEquiped);

                while (enemy.health > 0 || Game.vikingPlayer.health > 0)
                {
                    if (myChoice == "run" || myChoice == "run away")
                    {
                        break;
                    }
                    else if (enemy.health <= 0)
                    {
                        Console.WriteLine("You killed the " + enemy);
                        Console.WriteLine("******************************************************************************");

                        break;
                    }
                    else if (Game.vikingPlayer.health <= 0)
                    {
                        Console.WriteLine("The " + enemy + " killed you");
                        Console.WriteLine("******************************************************************************");

                        break;
                    }
                    else
                    {
                        Random randomNum = new Random();
                        battle(enemy);
                    }
                }
                break;
            default:
                Console.WriteLine("You encounter nothing");
                break;
        }
    }
    public void battle(Enemie enemy)
    {
        theOdds = randomNum.Next(0, 2);

        Console.WriteLine("******************************************************************************");

        Console.WriteLine("Will you 'attack', 'run away', 'eat' food, use 'item'");
        myChoice = Console.ReadLine();
        switch (myChoice)
        {
            case "attack":
                if (theOdds == 0)
                {
                    enemy.health -= Game.vikingPlayer.weaponDamage;
                    Console.WriteLine("You attacked the " + enemy);
                    Console.WriteLine("The " +enemy + " has " + enemy.health + "% of Health");//displays the players total health
                }
                else if (theOdds == 1)
                {
                    Game.vikingPlayer.health -= enemy.weaponDamage;
                    Console.WriteLine("The " + enemy + " attacked you. You lost " + enemy.weaponDamage + "% of health");//gives feedback on the damage done.
                    Console.WriteLine("you have " + Game.vikingPlayer.health + "% of Health");//displays the players total health
                }
                break;
            case "run away":
                Console.WriteLine("You ran away");
                break;
            case "eat":
                Game.vikingPlayer.eatFood();
                break;
            case "item":
                useableItem = Game.vikingPlayer.displayItems();

                if (theOdds == 0)
                {
                    enemy.health -= Game.vikingPlayer.weaponDamage;
                    Console.WriteLine("The " + enemy + " did not want your " + useableItem);
                    Console.WriteLine("The " + enemy + " attacked you. You lost " + enemy.weaponDamage + "% of health");//gives feedback on the damage done.
                    Console.WriteLine("you have " + Game.vikingPlayer.health + "% of Health");//displays the players total health
                }
                else if (theOdds == 1)
                {
                    Console.WriteLine("the " + enemy + " accepted the " + useableItem + ". It made the enemy weaker");//gives feedback on the damage done.
                    enemy.weaponDamage = 15;
                }
                break;
            default:
                Console.WriteLine("Not a valid command");
                battle(enemy);
                break;
        }//closes switch
    }//closes battle()
}