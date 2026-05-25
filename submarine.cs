public class Submarine
{
    public int hp = 100;
    public int power = 100;

    public const int scan = 3;
    public const int light = 8;
    public const int sonic = 10;

    public bool UsePower(int amount)
    {
        if (power >= amount)
        {
            power -= amount;
            return true;
        }
        return false;
    }

    public void damage(int amount)
    {
        hp -= amount;
        if (hp < 0)
        {
            hp = 0;
        }
    }

    public bool destroy()
    {
        if (hp <= 0 || power <= 0)
        {
            return true;
        }
        return false;
    }
}