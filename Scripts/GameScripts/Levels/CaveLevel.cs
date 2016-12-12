public class CaveLevel : LevelBase
{
    public CaveLevel()
    {
        //places where player can check for items.
        environment = new string[] {};
        itemsAvailable = new string[] {"rock", "chest", "skeleton", "stream", "dead bat", "moss"};
    }
}