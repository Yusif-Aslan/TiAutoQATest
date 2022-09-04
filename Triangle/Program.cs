internal class Program
{
    private static void Main(string[] args)
    {

        double ax = readNumber("x", "A");
        double ay = readNumber("y", "A");
        double bx = readNumber("x", "B");
        double by = readNumber("y", "B");
        double cx = readNumber("x", "C");
        double cy = readNumber("y", "C");

        double A = findSide(ax, ay, bx, by, "A");
        double B = findSide(bx, by, cx, cy, "B");
        double C = findSide(cx, cy, ax, ay, "C");
  
        if (A == B && B == C)
        {
            Console.WriteLine("Triangle is Equilateral");
        }
        else
        {
           Console.WriteLine("Triangle is not Equilateral");
        }


        if (A == B || B == C || C == A)
        {
           Console.WriteLine("Triangle is Isosceles");
        }
        else 
        {
           Console.WriteLine("Triangle is not Isosceles"); 
        }

        if (checkTriangleRight(A,B,C) == 0
          || checkTriangleRight(C,B,A) == 0
          || checkTriangleRight(B,C,A) == 0)
        {
            Console.WriteLine("Triangle is Right");
        }
        else
        {
            Console.WriteLine("Triangle is not Right"); 
        }


        double P = (A+B+C);
        Console.WriteLine("Perimetr: " + P);

        for (int i = 0; i < P; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    private static double readNumber(string coordinate, string dot)
    {
        Console.WriteLine(value: "Enter coordinate " + coordinate + " of dot " + dot + ":");
        double c;
        string value = Console.ReadLine();
         while (!Double.TryParse(value, out c))
        {
            Console.WriteLine("Try again");
            value = Console.ReadLine();
        }
        return c;
    }

    private static double findSide(double a, double b, double c, double d, string sideName)
    {
        double side = (Math.Sqrt((Math.Pow((c - a), 2)) + Math.Pow((d - b), 2)));
        Console.WriteLine("Lenght of " + sideName + " is: " + side);
        return side;
    } 

    private static double checkTriangleRight(double a, double b, double c)
    {
        return Math.Round(Math.Pow(a, 2) - (Math.Pow(b, 2) + Math.Pow(c, 2)));
    }
}