namespace PRG3F;

public class Bankomat
{
    public static void Main(String[] args)
    {
        int account = 0;
        
        //dodělat loop
        
        System.Console.WriteLine("Vyberte akci:\n 1 = Vypsat zůstatek na účtě\n 2 = Vložit peníze na účet\n 3 = Donate bance\n 4 = Free money\n 5 = Game mode\n 6 = Exit");
        int input = Console.Read() - '0'; //hnus! změnit
        Console.WriteLine(input);
        if (input == 1)
        {
            moneyBalance(account);
        }else if (input == 2)
        {
            insertMoney(account);
        }else if (input == 3)
        {
            donate(account);
        }else if (input == 4)
        {
            freeMoney();
        }else if (input == 5)
        {
            gameMode(account);
        }else if (input == 6)
        {
            exit(account);
        }
        else
        {
            userIsIdiot(account);
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

    public static void insertMoney(int account)
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

    public static void donate(int account)
    {
        Console.WriteLine("Kolik zbytečných peněz na účtě máte?");
        int donate = Console.Read();
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
    }

    public static void freeMoney()
    {
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⢄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⡻⢀⠆⣤⢷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⢹⣴⢊⣀⣿⡏⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⠙⡛⠦⢤⠟⣰⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡘⡄⠁⢀⠰⣸⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡼⣝⣁⢲⡐⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢘⡿⡁⠚⢋⠭⢱⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡏⠀⠄⠀⠒⣹⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡎⠖⢀⣠⠀⢀⠗⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⢃⠢⣄⣄⡂⠣⣜⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⣸⣱⣠⣂⠩⢷⡸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣰⣴⣛⣔⣺⡇⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣯⢗⡻⠶⠽⢤⣿⢋⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠴⣖⡶⣶⣟⢣⡙⢋⡭⢎⣻⣽⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⣠⣾⢏⣼⠏⣵⣿⣿⣣⠞⠦⡘⣐⢲⡏⠀⠀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⢀⣶⣯⣳⡀⢀⣾⠟⣣⠾⣇⠊⡴⣿⡥⠒⡌⠐⢤⡘⣼⠁⣰⠋⣴⡾⣭⡲⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⣠⢿⡿⠰⣿⣷⠿⣻⠩⢅⠋⠤⠁⣾⣯⡱⠑⡎⡐⢢⠘⣿⡰⠇⡌⣑⢚⡴⠗⠸⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⣀⣴⠟⢫⡔⢛⣾⣿⣻⠟⣡⠊⡜⣀⢣⣿⠖⣍⠧⠔⡠⠁⡞⣻⡟⡰⠜⡐⢊⠔⠨⢥⣇⣀⡀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⢀⣠⡾⢃⡥⢋⠐⢢⢽⣿⡿⢃⠣⡄⡑⠦⣬⢟⡦⡙⡤⢒⠰⣀⠡⢅⠻⣧⢒⡩⢐⢣⠘⠤⠈⣽⣥⢭⡑⣄⠀⠀⠀⠀⠀\n⠀⣴⡟⠤⡑⢎⡐⢤⠿⣛⣿⣟⢧⡃⠒⠠⡑⢊⢦⢏⣷⡱⡑⢊⡔⢢⠜⣂⢣⠙⠦⣁⠃⢆⡉⠲⢏⣿⠠⢌⡟⢊⠣⡀⠀⠀⠀\n⠐⣷⣻⣴⠵⣎⡐⠚⢛⣿⣿⣟⢮⡗⠠⠑⡠⢣⢎⢾⣿⡰⣉⠆⡘⢢⡜⠤⢊⡑⠂⠄⡘⠤⠌⡓⢊⢋⡙⢢⡙⢻⣆⡱⡀⠀⠀\n⠀⢸⣿⣸⣿⣄⢹⣤⣿⣿⣿⣿⣼⣿⣁⠇⣤⢁⡼⢧⣿⢡⠤⡤⢠⣇⢏⡸⢀⠠⢁⠠⢁⡄⣀⠉⠄⠄⡀⢁⠹⡄⢿⣠⡇⠀⠀\n⠀⠀⠹⣿⣵⣚⣻⢾⣿⣿⣿⣿⣿⣿⣿⣽⣲⢮⣝⣯⣟⣯⣟⣞⡯⣔⣺⡔⣣⢜⡠⢆⡡⣄⣴⣩⣼⡰⢠⠁⢠⢡⣻⣧⣻⠀⠀\n⠀⠀⠀⢻⣿⢿⠲⣬⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⣿⣿⣿⣿⣾⣿⣿⣿⣿⣽⢶⣿⣞⣿⣾⣿⢧⣿⣿⡱⢧⣏⣿⢤⣿⣷⣿⣦⠀\n⠀⠀⠀⠀⢻⣗⡳⢺⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣿⣿⣿⣿⣻⣿⣿⣟⣿⣿⣿⣿⣿⣿⣿⢯⣾⣿⣯⣿⣧⠇\n⠀⠀⠀⠀⠀⢿⣽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣿⣿⣿⣿⣿⣿⣿⣷⢿⣞⡿⣿⣿⣿⣿⡏⠀\n⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣾⡿⣾⢿⣿⣿⣿⣿⣷⠀\n⠀⠀⠀⠀⠀⠀⠘⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡷⣿⣻⣯⣿⢿⣿⣻⣿⣿⣟⣾⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠘⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣿⡽⣿⣻⣿⣿⣿⣿⣿⣽⣿⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣻⣿⣟⣷⢯⣿⡿⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣿⣳⢯⡳⣏⡾⣽⣾⠇⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣿⣽⣟⣷⣿⣞⣷⡽⣽⣿⡟⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣽⣾⣟⡷⣿⢽⣻⣿⣿⡇⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⡟⣹⢣⣟⣷⣿⡿⡇⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⣷⢯⣞⡴⣣⣿⣿⡟⣯⡽⡟⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣞⣿⣿⣾⣿⡿⢧⣻⢵⡻⠁⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠛⠿⢿⣿⣿⣿⣿⣿⣿⣷⣿⣿⣿⣏⣧⠽⠚⠁⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠉⠉⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
    }

    public static void gameMode(int account)
    {
        Random random = new Random();
        Console.WriteLine("You entered the game mode.");
        Console.WriteLine("Zvolte sázku.");
        int bet = Console.Read();
        Console.WriteLine("Vyberte štastné číslo. 0-9");
        int happyNumber = Console.Read();
        Console.WriteLine("Vsadili jste " + bet + " CZK na číslo " + happyNumber);
        int nuber = random.Next(0, 9);
        if (happyNumber == nuber)
        {
            Console.WriteLine("HURÁ. Vyhrál si " + bet*2);
            account = account + bet*2;
            Console.WriteLine("Zůstatek na vašem účtu je " + account);
        }
    }

    public static void exit(int account)
    {
        Console.WriteLine("Sbohem");
        account = account - 1;
        Console.WriteLine("Zůstatek na vašem účtu je " + account);
    }

    public static void userIsIdiot(int account)
    {
        Console.WriteLine("Zvolil jste neplatnou možnost. Pokuta 50 CZK");
        account = account - 50;
        Console.WriteLine("Zůstatek na vašem účtu je " + account);
    }
}