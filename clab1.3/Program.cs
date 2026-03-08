
class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть a");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть n");
        int n = int.Parse(Console.ReadLine());

        double total = 0;

        for (int i = n; i >= 1; i--)
        {
            double powerValue = Math.Abs(Math.Pow(a, i));
            total += Math.Log(powerValue);
        }
        Console.WriteLine($"Total = {total}");
    }
}
