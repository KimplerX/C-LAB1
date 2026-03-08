class Program
{
    static void Main()
    {
        double Sum = 0;
        Console.WriteLine("Введіть x: ");
        double x = double.Parse(Console.ReadLine());
        if (Math.Abs(x) < 1)
        {
            for (int n = 1; n <= 30; n += 2)
            {
                Sum += Math.Pow(x, n) / n;
            }
            Sum *= 2;
            Console.WriteLine($"Сума = {Sum}");
        } else
        {
            Console.WriteLine("x повинен бути менше 1 за модулем!");
        }
    }
}