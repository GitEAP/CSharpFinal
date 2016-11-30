public class Dwarf
{
    public static Enemie DwarfEnemie = new Enemie();//Makes a new enemie.
                   // Random randomNum = new Random();

    public Dwarf()
    {
        DwarfEnemie.health = 100;
        DwarfEnemie.armor = 10;
        DwarfEnemie.weaponEquiped = "two handed axe";// get random weapon from Inventories.cs
        DwarfEnemie.weaponDamage = 14;
    }
}

