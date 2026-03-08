class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double e = Math.E;
        double result;

        if (y < x)
        {
            result = y * Math.Pow(e, x);
        } else if (y == x)
        {
             result = y * x;
        } else if (y > x)
        {
            result = x * Math.Pow(e, y);
        }

        Console.WriteLine($"Результат: {result}");
    }
}