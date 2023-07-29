
class ProgramCalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Reduce(int a, int b)
    {
        return a - b;
    }
    public int Multiplication(int a, int b)
    {
        return a * b;
    }
    public double Division(int a, int b)
    {
        try
        {
            if (b == 0)
            {
            throw new Exception("you are trying to divide by zero");
            }
            return a / b;
        } catch(Exception c)
        {
            Console.WriteLine(c.Message);
            return 0;
        }
    }
    public double SquareRoot(int a)
    {
        return Math.Sqrt(a);
    }
    public static void Main()
    {
        ProgramCalculator pc = new ProgramCalculator();
        string s = "any";

        while (!s.Equals("q"))
        {
            Console.WriteLine("Choose a: ");
        s = Console.ReadLine();
        int a = int.Parse(s);

        Console.WriteLine("Choose b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose action(a - add, r - reduse, m - multiple, d - divide, s - square root, q - exit): ");
        s = Console.ReadLine();

            switch (s)
            {
                case "a":
                    Console.WriteLine("Result: " + pc.Add(a, b).ToString());
                    break;
                case "r":
                    Console.WriteLine("Result: " + pc.Reduce(a, b).ToString());
                    break;
                case "m":
                    Console.WriteLine("Result: " + pc.Multiplication(a, b).ToString());
                    break;
                case "d":
                    Console.WriteLine("Result: " + pc.Division(a, b).ToString());
                    break;
                case "s":
                    Console.WriteLine("Square root from a: " + pc.SquareRoot(a).ToString()
                        + "Square root from b: " + pc.SquareRoot(b));
                    break;
                default:
                    Console.WriteLine("Incorrect action");
                    break;
            }
        }
    }
}
