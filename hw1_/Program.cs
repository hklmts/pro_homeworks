
using hw1_;
using hw1_.hw._2._1._5_hw;
using hw1_.hw._2._1._7_hw;
using hw1_.hw3.hw3_3;
using hw1_.hw4.hw4_2;
using hw1_.hw4.hw4_3;
using hw1_.hw4.hw4_4;
using hw1_.hw5;
using hw1_.hw7_threading;
using hw2;
using hw2.hw2._2;
using hw2.hw2._3;
using hw2.hw3.hw3_1;
using hw2.hw3.hw3_2;
using hw2.hw4.hw4_1.Employee;

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
    public static void MainOld()
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
    public static void Main()
    {

        //test hw 2.1
        /*        Money wallet = new Money(50.25);
                wallet.SavedValue();
                Money iceCreamPrice = new Money(15.50);
                Product iceCream = new Product("Yammy-yammy", iceCreamPrice);
                wallet.BuyProduct(iceCream);
                wallet.SavedValue();*/

        // test hw2.2
        /*      Violin v = new Violin("My v", "Super violin sound");
                v.Sound();
                v.Show();
                v.Desc();
                v.History();*/
        //test hw2.3
        /*        DecimalNumber myDigit = new DecimalNumber(123);
                myDigit.DecimalToBinary();
                myDigit.DecimalToOctal();
                myDigit.DecimalToHex();*/

        //test hw 3.1 3.2 3.3
        /*hw2.hw3.hw3_1.Array numbers = new hw2.hw3.hw3_1.Array(new int[5] { 2, 3, 4, 5, 7 });
        numbers.Show();
        numbers.Show("My numbers: ");

        NextArray nextArray = new NextArray(new int[5] { 3, 6, 68, 41, 4 });
        nextArray.Show("Numbers in nextArray: ");
        Console.WriteLine($"Min: {nextArray.Min()}, max: {nextArray.Max()}, avg {nextArray.Avg()}");
        Console.WriteLine($"41 -> {nextArray.Search(41)}, 5 -> {nextArray.Search(5)}");

        SortNextArray sortedArray = new SortNextArray(new int[7] { 13, 62, 67, 41, 4, -100, 4 });
        sortedArray.Show("Numbers before sort: ");
        sortedArray.SortDesc();
        sortedArray.Show("Numbers after sort desc: ");*/

        // test hw 4

        /* Employee empOfTheWeek = new Employee(1, "Nora", 555479641, 1000.00f);
         Employee empOfTheMonth = new Employee(1, "Nora", 555479641, 1000.00f);

         float incrSalary = 75.50f;

         empOfTheWeek += incrSalary;

         Console.WriteLine($"New salary {empOfTheWeek.Salary}");

         Console.WriteLine($"Salary matching: {empOfTheWeek == empOfTheMonth}");
         Console.WriteLine($"not matched 2 employers: {empOfTheWeek != empOfTheMonth}");
         Console.WriteLine($"empOfTheWeek > empOfTheMonth: {empOfTheWeek > empOfTheMonth}" +
             "\n---------after substact salary----------");
         empOfTheWeek -= incrSalary;
         Console.WriteLine($"not matched 2 employers: {empOfTheWeek != empOfTheMonth}");
         Console.WriteLine($"empOfTheWeek > empOfTheMonth: {empOfTheWeek > empOfTheMonth}");

         Matrix nemo = new Matrix(new int[4] { 4, 6, 2, 41 }, "Nemo");
         Matrix dory = new Matrix(new int[3] { 8, 20, 37 }, "Dory");
         Console.WriteLine("-----------MATRIX TEST--------------");
         Console.WriteLine($"{nemo} and {dory}");
         Console.WriteLine(nemo + dory);
         Console.WriteLine(nemo - dory);
         Console.WriteLine(nemo * dory);
         Console.WriteLine(nemo * 2);
         Matrix doryClone = new Matrix(new int[3] { 8, 20, 37 }, "Dory");

         Console.WriteLine($"Not matched test: {dory != doryClone}");
         Console.WriteLine("-----------CREDITCARD TEST--------------");
         CreditCard halaCard = new CreditCard(0, "Hala", 123);
         halaCard.GetInfo();
         CreditCard anotherHalaCard = new CreditCard(200.25f, "Hala", 123);
         anotherHalaCard.GetInfo();
         Console.WriteLine($"Matching cards: {!(halaCard != anotherHalaCard)}");
         anotherHalaCard.Owner = "Lilya";
         anotherHalaCard.GetInfo();

         Console.WriteLine($"Matching card after gifting: {!(halaCard != anotherHalaCard)}");
         Console.WriteLine($"Matching cww on cards: {halaCard == anotherHalaCard}");
         halaCard += 200.28f;
         halaCard.GetInfo();
         Console.WriteLine($"halaCard > anotherHalaCard, (matching money) {halaCard > anotherHalaCard}");

         City khariv = new City("Kharkiv", "east of UKraine", 1421125, true);
         City dnipro = new City("Dnipro", "center of Ukraine", 984423, true);

         Console.WriteLine(khariv + 587);
         khariv.ShowInfo();*/

        // test hw5
        /*StagePlay test;
       
        for (int i = 0; i < 3; i++)
        {
          //  test = new StagePlay();
        }*/
        //GC.Collect();
        //Console.Read();

        /*Shop testShop = new Shop("Paradise", "Shevchenco, 37", "shoesShop");
        testShop.ShowShop();
        testShop.Dispose();
        testShop = new Shop("Flowers of sun", "Karpatska, 53", "flowerShop");
        testShop.ShowShop();

        ModernShop modernShop = new("Mojito", "Fontanna, 1", "liquorStore");
        for (int i = 1; i <= 10; i++)
        {
            modernShop = new($"Mojito(test{i})", "Fontanna, 1", "liquorStore");
            if (i%2 == 0)
            {
                modernShop.Dispose();
            }
        }

        GC.Collect();
        Console.Read();*/
        SleepingBarber sleepingBarber = new SleepingBarber();
        sleepingBarber.Barber();





    }
}
