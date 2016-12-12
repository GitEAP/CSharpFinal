using System;
public class vikingPlayer : Player
{

    Random randomNum = new Random();

    public vikingPlayer()
    {
        health = 100;
        armor = randomNum.Next(1, 50);
    }

}