public class Ogre
{
    public static Enemie ogreEnemie = new Enemie();//Makes a new enemie.

    public Ogre()
    {
        ogreEnemie.health = 100;
        ogreEnemie.armor = 10;
        ogreEnemie.weaponEquiped = "axe";// get random weapon from Inventories.cs
        ogreEnemie.weaponDamage = 7;
    }
}

