class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть a, b, c: ");
        string input = Console.ReadLine();
        string[] values = input.Split(' ');
        int a = int.Parse(values[0]);
        int b = int.Parse(values[1]);
        int c = int.Parse(values[2]);

        if ((a <= 9 && a >=3) && (a <= c && a >= b))
        {
            Console.WriteLine($" a належить проміжку [3, 9] та [{b}, {c}]");
        }
        else
        {
            Console.WriteLine($" a НЕ належить проміжку [3, 9] та [{b}, {c}]");
        }
    }
}
