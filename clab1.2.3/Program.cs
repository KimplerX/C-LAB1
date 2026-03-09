class Program 
{
    static void Main()
    {   
        Console.WriteLine("Введіть x1 y1 x2 y2 x3 y3 через пробіл:");
        string[] v = Console.ReadLine().Split(' ');

        double x1 = double.Parse(v[0]), y1 = double.Parse(v[1]);
        double x2 = double.Parse(v[2]), y2 = double.Parse(v[3]);
        double x3 = double.Parse(v[4]), y3 = double.Parse(v[5]);

        double a2 = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
        double b2 = Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2);
        double c2 = Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2);

        double epsilon = 1e-9; 

        if (Math.Abs(a2 - b2) < epsilon || 
            Math.Abs(b2 - c2) < epsilon || 
            Math.Abs(a2 - c2) < epsilon)
        {
            Console.WriteLine("Трикутник рівнобедрений");
        } else {
            Console.WriteLine("Трикутник НЕ рівнобедрений");
        }
    }
}
