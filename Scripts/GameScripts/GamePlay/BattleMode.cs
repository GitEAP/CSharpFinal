using System;
public class BattleMode
{
    public string myChoice;
    Random randomNum = new Random();
    public int theOdds;
    public string useableItem;
    public int chooseWeapon;
    public void chooseMyWeapon()
    {
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("What weapon will you choose? (type the name of the weapon in your inventory)");
        Game.vikingPlayer.displayWeapons();
        //converts the string to an int. Assigns the weapon to the player.
        chooseWeapon = Game.vikingPlayer.getWeaponNumber(Console.ReadLine());
        Console.WriteLine("******************************************************************************");
        Game.vikingPlayer.assignWeapon(chooseWeapon);
        Console.WriteLine("You are using a " + Game.vikingPlayer.weaponEquiped);
    }
    public void Encounter(int i, Enemie enemy)
    {
        switch (i)
        {
            case 0:
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("You have encounter an " + enemy + "!!!!!!!!!!!!");
                Console.WriteLine("The " + enemy + " has a " + enemy.weaponEquiped);

                chooseMyWeapon();//player chooses a weapon

                while (enemy.health >= 0 || Game.vikingPlayer.health >= 0)
                {
                    if (myChoice == "run" || myChoice == "run away")
                    {
                        myChoice = "";
                        break;
                    }
                    else if (enemy.health <= 0)
                    {
                        Console.WriteLine("You killed the " + enemy);
                        Console.WriteLine("Your weapon broke! and you now have " + Game.vikingPlayer.health + "% of health.");
                        vikingPlayer.weaponInventory.Remove(Game.vikingPlayer.weaponEquiped);
                        Console.WriteLine("******************************************************************************");

                        break;
                    }
                    else if (Game.vikingPlayer.health <= 0)
                    {
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
                Console.WriteLine("You decided to keep moving to the next area.");
                Console.WriteLine("******************************************************************************");

                break;
        }
    }
    public void battle(Enemie enemy)
    {
        theOdds = randomNum.Next(0, 2);
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("Will you 'attack', 'run away', 'eat' food, use 'item', 'change' weapon (type the word(s) inside the ' ')");
        myChoice = Console.ReadLine();
        switch (myChoice)
        {
            case "attack":
                if (theOdds == 0)
                {
                    enemy.health -= Game.vikingPlayer.weaponDamage;
                    Console.WriteLine("You attacked the " + enemy);
                    Console.WriteLine("The " + enemy + " has " + enemy.health + "% of Health");//displays the players total health
                }
                else if (theOdds == 1)
                {
                    Console.WriteLine("You missed and the " + enemy + " attacked you. You lost " + enemy.weaponDamage + "% of health");//gives feedback on the damage done.
                    //checks to see if you have armor
                    checkArmor(enemy);
                    Console.WriteLine("you have " + Game.vikingPlayer.health + "% of Health");//displays the players total health
                }
                break;
            case "run away":
                Console.WriteLine("You ran away");
                Console.WriteLine("******************************************************************************");

                break;
            case "eat":
                Game.vikingPlayer.displayFood();
                Game.vikingPlayer.eatFood();
                Console.WriteLine("While you were eating the " + enemy + " got stronger");
                enemy.weaponDamage += 5;
                break;
            case "item":
                useableItem = Game.vikingPlayer.displayItems();
                theOdds = randomNum.Next(0, 2);
                if (useableItem == null)
                {
                    Console.WriteLine("You don't have any items in your inventory");
                    Console.WriteLine("The " + enemy + " got angry with you that he became stronger");
                    enemy.weaponDamage += 5;

                }
                else if (theOdds == 0)
                {
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine("The " + enemy + " did not want your " + useableItem);
                    Console.WriteLine("The " + enemy + " attacked you");
                    checkArmor(enemy);
                    Console.WriteLine("you have " + Game.vikingPlayer.health + "% of Health");//displays the players total health
                }
                else if (theOdds == 1)
                {
                    Console.WriteLine("the " + enemy + " accepted the " + useableItem + ". It made the enemy weaker");//gives feedback on the damage done.
                    enemy.weaponDamage -= 10;
                    if (enemy.weaponDamage <= 0)
                    {
                        enemy.weaponDamage = 1;
                    }
                }
                break;
            case "change":
                chooseMyWeapon();
                Console.WriteLine("While you were changing your weapon the " + enemy + " got stronger");
                enemy.weaponDamage += 5;
                break;
            default:
                Console.WriteLine("Not a valid command");
                battle(enemy);
                break;
        }//closes switch
    }//closes battle()

    public void checkArmor(Enemie enemy)
    {
        if (Game.vikingPlayer.health <= 40)
        {
            Console.WriteLine("Your health % is in a critical level!");//Gives player a warning
            //if it's 0 or negative it sets it to 0(armor)
            if (Game.vikingPlayer.armor <= 0)
            {
                Game.vikingPlayer.armor = 0;
                Console.WriteLine("Your armor broke!");
                Game.vikingPlayer.health -= enemy.weaponDamage;

            }
            //if it's zero it tells the player they don't have any armor
            else if (Game.vikingPlayer.armor == 0)
            {
                Console.WriteLine("You don't have any armor.");
                Game.vikingPlayer.health -= enemy.weaponDamage;


            }
            //if they do have armor they get half the damage and the other half is applied to the armor
            else
            {
                Console.WriteLine("Your armor decreased the damage.");
                Game.vikingPlayer.armor -= (enemy.weaponDamage / 2);
                Console.WriteLine("You now have " + Game.vikingPlayer.armor + "% of armor");
                Game.vikingPlayer.health -= (enemy.weaponDamage / 2);
            }
        }
        //if your health is not in a critical level apply normal damage
        else
        {
            Game.vikingPlayer.health -= enemy.weaponDamage;

        }
    }
}