using System.Globalization;
using System.Reflection.PortableExecutable;


namespace ConsoleApp29
{
    public static class Work
    {
        public static void Task1()
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (a % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (a % 3 == 0 & a % 5 == 0)
            {
                Console.WriteLine("Fizz\r\nBuzz");
            }
            else if (a < 1 & a > 100)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                Console.WriteLine(a);
            }
        }
        public static void Task2()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a / b;
            Console.WriteLine(c);
        }
        public static void Task3()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int[] numbers = { a, b, c, d };
            foreach (int i in numbers) { Console.Write(i + " "); }
        }
        public static void Task4()
        {
            int[] numbers = new int[6];
            int res = 0, t = 0, y = 0, r = 1;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                res = int.Parse(Console.ReadLine());
                numbers[i] = res;
            }
            for (int i = a; i < numbers.Length; i++)
            {
                t = numbers[i];
            }
            for (int i = b; i < numbers.Length; i++)
            {
                y = numbers[i];
            }
            while (r < numbers.Length)
            {
                if (r == a)
                {
                    numbers[r] = t;
                }
                if (r == b)
                {
                    numbers[r] = y;
                }
                r++;
            }
            foreach (int i in numbers) { Console.Write(i + " "); }
        }
        public static void Task5()
        {
            Console.WriteLine("Введіть дату у форматі DD.MM.YYYY:");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out DateTime date))
            {
                string dayOfWeek = date.ToString("dddd", new CultureInfo("en-US"));
                Console.WriteLine($"{dayOfWeek}");
            }
        }
        public static void Task6()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b == 1)
            {
                a = a - 30;
                a = a / 2;
                Console.WriteLine(a);
            }
            if (b == 2)
            {
                a = a + 30;
                a = a * 2;
                Console.WriteLine(a);
            }
        }
        public static void Task7()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                a = b;
                b = a;
            }
            while (a < b)
            {
                if (a % 2 == 0)
                {
                    Console.Write(a + " ");
                }
                a++;
            }
        }
    }
}
