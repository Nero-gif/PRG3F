namespace PRG3F;

public class test710
{
    public static void Main(String[] args)
    {
        ageToArmy();
        evenNumber();
        rectanglePerimeter();
    }

    public static void ageToArmy()
    {
        Console.WriteLine("Zadejte věk.");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Jsi svéprávný? ano/ne");
        string? answer = Console.ReadLine();

        if (answer == "ano")
        {
            if (age >= 18)
            {
                Console.WriteLine("Vítej v armádě!");
            }
            else if (age <= 0)
            {
                Console.WriteLine("Tak určitě...");
            }
            else
            {
                int remainingAge = 18 - age;
                Console.WriteLine("Zatím se přidat nemůžeš, ale budeme se na tebe těšit za " + remainingAge + "let.");
            }
        }else if (answer == "ne")
        {
            Console.WriteLine("Tak třeba jindy.");
            if (age <= 0)
            {
                Console.WriteLine("Tak určitě...");
            }
            else
            {
                int remainingAge = 18 - age;
                Console.WriteLine("Zatím se přidat nemůžeš, ale budeme se na tebe těšit za " + remainingAge + "let.");
            }
        }
        else
        {
            Console.WriteLine("Zadejte platnou odpověď prosím!");
            
        }
    }

    public static void evenNumber()
    {
        Console.WriteLine("Zadejte celé kladné číslo.");
        int number = Console.Read();
        int numberOfEven = 0;
        for (int i = 1; i < number; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                numberOfEven++;
            }
        }
        Console.WriteLine("Kladných čísel je " + numberOfEven);
    }

    public static void rectanglePerimeter()
    {
        Console.WriteLine("Zadejte stranu a v obdélníku.");
        int a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Zadejte stranu b v obdélníku.");
        int b = int.Parse(Console.ReadLine());
        
        int perimeter = (a + b) * 2;
        Console.WriteLine("Obvod je "+ perimeter);
    }
}