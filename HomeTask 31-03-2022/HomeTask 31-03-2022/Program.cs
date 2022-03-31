using System;

namespace HomeTask_31_03_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 2;
            while (input > 0 && input <= 5)
            {
                Console.WriteLine("1.Sum\n2.Subtract\n3.Divide\n4.Mulitply\n5.power");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("enter first input: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter second input: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Calculator.Sum(a, b));
                        break;

                    case 2:
                        Console.WriteLine("enter first input: ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter second input: ");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Calculator.Subtract(x, y));
                        break;
                    case 3:
                        Console.WriteLine("enter first input: ");
                        int z = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter second input: ");
                        int t = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Calculator.Divide(z, t));
                        break;
                    case 4:
                        Console.WriteLine("enter first input: ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter second input: ");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Calculator.Multiply(c, d));
                        break;
                    case 5:
                        Console.WriteLine("pls enter value");
                        int value = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(value.Power());
                        break;

                    default:
                        Console.WriteLine("Not foud");
                        break;
                }
            }
        }
    }
}
