class Program
{
	static void Main()
	{   
        Console.WriteLine("Введіть довжину сторони квадрата: ");
		double side = double.Parse(Console.ReadLine());
        if (side > 0)
        {
            double area = side * side;
		    double perimeter = 4 * side;

		    Console.Write($"Площа = {area},  ");
		    Console.WriteLine($"Периметр = {perimeter}");
        } else
        {
            Console.WriteLine("Від'ємне число!");
        }
		
	}
}
