using System;
public class LevelBase {
    public string StartMessage;
    public string[] environment;//places where player can check for items.
    public string[] itemsAvailable;//new random items are made in each new area.

    //lets player know which level has been entered. 
    public void Enter() {
        Console.WriteLine(StartMessage);
    }
}