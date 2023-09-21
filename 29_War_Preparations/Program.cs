namespace _29_War_Preparations;

public class Program
{
    static void Main(string[] args)
    {
        Sword sword = new Sword(Material.Iron, Gemstone.None, 10, 2);
        Sword s2 = sword with { mat = Material.Steel, gem = Gemstone.Emerald, length = 300, xGuardWidth = 0 };
        Sword s3 = sword with { mat = Material.Binarium, gem = Gemstone.Bitstone };

        Console.ReadLine();
    }
}

public enum Material
{
    Wood, Bronze, Iron, Steel, Binarium
}

public enum Gemstone
{
    Emerald, Amber, Sapphire, Diamond, Bitstone, None
}

public record Sword (Material mat, Gemstone gem, int length, int xGuardWidth);