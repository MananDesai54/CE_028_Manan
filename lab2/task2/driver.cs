using System;
using calculator;

namespace Driver
{
    public class Calc
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter num1");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = Int32.Parse(Console.ReadLine());
            Add a = new Add();
            Mul m = new Mul();
            Console.WriteLine(a.Addition(num1, num2));
            Console.WriteLine(m.Multiplication(num1, num2));
            Console.ReadLine();
        }
    }
}