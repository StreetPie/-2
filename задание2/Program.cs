// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.WriteLine("x");
    double x = Convert.ToDouble(Console.ReadLine());
    if (x == 0)
    {
        Console.WriteLine("x не равно 0");
        continue;

    }
    else
    {
        Console.WriteLine("y");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("z");
        double z = Convert.ToDouble(Console.ReadLine());

        double D = (y * y) - 4 * x * z;

        if (D < 0)
        {
            Console.WriteLine("Нет решения");
        }
        else if (D == 0)
        {
            Console.WriteLine($"x1 = {-y / (2 * x)}");

        }
    
        else if (D > 0)
        {
            Console.WriteLine($"x1 = {-y + Math.Sqrt(D) / (2 * x)}");
            Console.WriteLine($"x2 = {-y - Math.Sqrt(D) / (2 * x)}");
        }
    }


}
