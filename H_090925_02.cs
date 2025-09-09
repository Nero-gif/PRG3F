namespace PRG3F;

public class H_090925_02
{
    public static void Main02(string[] args)
    {
        Console.WriteLine("Zadej jmeno");
        var jmeno = Console.ReadLine();
        Console.WriteLine("Zadej přijmení");
        var prij = Console.ReadLine();
        Console.WriteLine($"Vitej {jmeno} {prij}");
    }
}