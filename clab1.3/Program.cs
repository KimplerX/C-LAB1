class Program
{
    static void Main()
    {
        Console.Write("Введіть a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введіть n: ");
        int n = int.Parse(Console.ReadLine());

        double total = 0;
        double lnA = Math.Log(Math.Abs(a));

        for (int i = n; i >= 1; i--)
        {
            total += i * lnA;
        }

        Console.WriteLine($"Total = {total}");
    }
}
