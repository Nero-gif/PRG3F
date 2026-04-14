namespace PRG3F;

public class Bankomat
{
    public static void Main1(String[] args)
    {
        int account = 0;

        bool someArgumentToEndTheWhile = true;
        while (someArgumentToEndTheWhile)
        {
            System.Console.WriteLine(
                "Vyberte akci:\n 1 = Vypsat zůstatek na účtě\n 2 = Vložit peníze na účet\n 3 = Donate bance\n 4 = Free money\n 5 = Game mode\n 6 = Exit");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                moneyBalance(account);
            }
            else if (input == 2)
            {
                account = insertMoney(account);
            }
            else if (input == 3)
            {
                account = donate(account);
            }
            else if (input == 4)
            {
                freeMoney();
            }
            else if (input == 5)
            {
                account = gameMode(account);
            }
            else if (input == 6)
            {
                account = exit(account);
                someArgumentToEndTheWhile = false;
            }
            else
            {
                account = userIsIdiot(account);
            }
        }
    }

    public static void moneyBalance(int account)
    {
        System.Console.WriteLine("Zůstatek na vašem účtu je " + account);
        if (account <= 5063)
        {
            Console.WriteLine("To neni moc brácho...");
        }else if (account <= 100000)
        {
            Console.WriteLine("To neni špatný.");
        }
        else
        {
            Console.WriteLine("You are rich asf!");
        }
    }

    public static int insertMoney(int account)
    {
        Console.WriteLine("Zadajte částku ke vložení.");
        int insertion = int.Parse(Console.ReadLine());
        if (insertion > 0)
        {
            account = account + insertion;
            Console.WriteLine("Na účet bylo vloženo " + insertion + "CZK");
        }
        else
        {
            Console.WriteLine("Asi máš trochu problém. Pohodlně se usaď a počkej až ti přijdou fešáci v uniformách pomoct.");
        }
        
        return account;
    }

    public static int donate(int account)
    {
        Console.WriteLine("Kolik zbytečných peněz na účtě máte?");
        int donate = int.Parse(Console.ReadLine());
        if (donate <= 0)
        {
            Console.WriteLine("Dobrej pokus, ale smůla.");
            account = 0;
            Console.WriteLine("Zůstatek na vašem účtu je " + account);
        }else if (donate > account)
        {
            Console.WriteLine("Tolik nemáš, ale děkujeme.");
            account = 0;
            Console.WriteLine("Zůstatek na vašem účtu je " + account);
        }
        else
        {
            Console.WriteLine("Děkujeme převelice.");
            account = account - donate;
            Console.WriteLine("Zůstatek na vašem účtu je " + account);
        }
        
        return account;
    }

    public static void freeMoney()
    {
        Console.WriteLine("                      /´¯/) \n                    ,/¯  / \n                   /    / \n             /´¯/'   '/´¯¯`·¸ \n          /'/   /    /       /¨¯\\ \n        ('(   ´   ´     ¯~/'   ') \n         \\                 '     / \n          ''   \\           _ ·´ \n            \\              ( \n              \\             \\   ");
    }

    public static int gameMode(int account)
    {
        Random random = new Random();
        
        Console.WriteLine("You entered the game mode.");
        
        Console.WriteLine("Zvolte sázku.");
        int bet = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Vyberte štastné číslo. 0-9");
        int happyNumber = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Vsadili jste " + bet + " CZK na číslo " + happyNumber);
        
        int nuber = random.Next(0, 9);
        Console.WriteLine("Padlo " + nuber);
        
        if (happyNumber == nuber)
        {
            Console.WriteLine("HURÁ. Vyhrál si " + bet*2);
            account = account + bet*2;
            Console.WriteLine("Zůstatek na vašem účtu je " + account);
        }
        
        return account;
    }

    public static int exit(int account)
    {
        Console.WriteLine("Sbohem");
        account = account - 1;
        Console.WriteLine("Zůstatek na vašem účtu je " + account);

        return account;
    }

    public static int userIsIdiot(int account)
    {
        Console.WriteLine("Zvolil jste neplatnou možnost. Pokuta 50 CZK");
        account = account - 50;
        Console.WriteLine("Zůstatek na vašem účtu je " + account);
        
        return account;
    }
}