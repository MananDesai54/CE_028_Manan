using Addition;
using System;
namespace Driver
{
    public class Driver
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter num1");
            String n1 = Console.ReadLine();
            int num1 = Int32.Parse(n1);
            Console.WriteLine("Enter num2");
            String n2 = Console.ReadLine();
            int num2 = Int32.Parse(n2);
            Addition.AddNum add = new Addition.AddNum();
            Console.WriteLine(add.add(num1, num2));
            Console.WriteLine(add.sub(num1, num2));
        }  
    }
}