namespace APBDTask1;

public class Program
{
    public static void Main(string[] args)
    {
        var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        foreach (var i in list)
            Console.WriteLine(i);

        Console.WriteLine("Program end");
    }
}