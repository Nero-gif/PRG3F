namespace PRG3F;

public class testOOP
{
    public static void Main1(string[] args)
    {
        //ukol1
        var todo = new TodoItem("Napsat první třídu");
        var hw = new TodoItem("Udělat úkol z matematiky");
        todo.MarkDone();
        Console.WriteLine($"{todo.Text}: {todo.IsDone}"); // Napsat první třídu: Hotovo
        Console.WriteLine($"{hw.Text}: {hw.IsDone}"); // Udělat úkol z matematiky: Rozpracované
        
        
        //ukol2
        int[] pole = { 0, 1, 0, 2, 0, 1, 0, 2, 0 };
        for (int i = 0; i < 3; i++)
        {
            String line = "|";
            for (int j = 0; j < 3; j++)
            {
                String mark = "";
                if (pole[i+j] == 0)
                {
                    mark = "_";
                }
                else if (pole[i+j] == 1)
                {
                    mark = "x";
                }
                else if (pole[i+j] == 2)
                {
                    mark = "o";
                }
                else
                {
                    mark = "userIsIdiot";
                }
                line = line + mark + "|";
                
            }
            Console.WriteLine(line);
        }
        
        
        //ukol3
        
    }
}

public class TodoItem(string text)
{
    public string Text = text;
    public String IsDone = "Zadáno";

    public void MarkDone()
    {
        IsDone = "Dokončeno";
    }
}
