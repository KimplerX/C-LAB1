class Program 
{
    static void Main()
    {   
        Console.WriteLine("Введіть x1 x2 x3 y1 y2 y3: ");
        string input = Console.ReadLine();
        string[] values = input.Split(' ');

        double x1 = double.Parse(values[0]);
        double x2 = double.Parse(values[1]);
        double x3 = double.Parse(values[2]);
        double y1 = double.Parse(values[3]);
        double y2 = double.Parse(values[4]);
        double y3 = double.Parse(values[5]);

        double d1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double d2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        double d3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

        if ((d1 == d2) || (d2 == d3) || (d1 == d3))
        {
            Console.WriteLine("Трикутник рівнобедрений");
        } else
        {
            Console.WriteLine("Трикутник НЕ рівнобедрений");
        }
    }
}
