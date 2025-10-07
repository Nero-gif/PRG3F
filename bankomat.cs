namespace PRG3F;

public class bankomat
{
    public static void Main(String[] args)
    {
        int account = 0;
        
        System.Console.WriteLine("Vyberte akci:\n 1 = Vypsat zůstatek na účtě\n 2 = Vložit peníze na účet\n 3 = Donate bance\n 4 = Free money\n 5 = Game mode\n 6 = Exit");
        int input = Console.Read();

        if (input == 1)
        {
            moneyBalance(account);
        }else if (input == 2)
        {
            insertMoney;
        }else if (input == 3)
        {
            donate;
        }else if (input == 4)
        {
            freeMoney;
        }else if (input == 5)
        {
            gameMode;
        }else if (input == 6)
        {
            exit;
        }
        else
        {
            userIsIdiot;
        }
    }

    public void moneyBalance(int account)
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

    public void insertMoney(int account)
    {
        Console.WriteLine("Zadajte částku ke vložení.");
        int insertion = Console.Read();
        if (insertion > 0)
        {
            account = account + insertion;
            Console.WriteLine("Na účet bylo vloženo " + insertion + "CZK");
        }
        else
        {
            Console.WriteLine("Asi máš trochu problém. Pohodlně se usaď a počkej až ti přijdou fešáci v uniformách pomoct.");
        }
    }

    public void donate(int account)
    {
        Console.WriteLine("Kolik zbytečných peněz na účtě máte?");
        int donate = Console.Read();
        if (donate <= 0)
        {
            Console.WriteLine("Dobrej pokus, ale smůla.");
            account = 0;
            Console.WriteLine("Zůstatek na vašem účtu je " + account);
        }else if (donate > account){}
    }
}