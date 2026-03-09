class Program
{
    static void Main()
{
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    double result;

    if (y < x)
    {
        result = y * Math.Exp(x);
    }
    else if (y > x)
    {
        result = x * Math.Exp(y);
    }
    else 
    {
        result = y * x;
    }

    Console.WriteLine($"Результат: {result}");
}

}