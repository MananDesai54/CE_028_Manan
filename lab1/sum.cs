using System;
namespace Sum {
    class SumNum {
        public static void Main(string[] args) {
            Console.WriteLine("Enter num1");
            String n1 = Console.ReadLine();
            int num1 = Int32.Parse(n1);
            Console.WriteLine("Enter num2");
            String n2 = Console.ReadLine();
            int num2 = Int32.Parse(n2);
            Console.WriteLine(num1 + num2);
        }
    }
}