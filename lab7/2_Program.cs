using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "akash", "darshan", "dhaval", "raj", "rushik", "jemis", "kamani", "pranav", "shivam", "ratan" };
            
            var result1 = names.Where(name => name[0] == 'k');
            Console.WriteLine("all names with the first letter K:-");
            foreach (var x in result1)
            {
                Console.Write("{0} ",x);
            }

            var result2 = names.Where(name => name.Length < 4);
            Console.WriteLine("\nall names whose string length is less than 4:-");
            foreach (var x in result2)
            {
                Console.Write("{0} ", x);
            }

            var result3 = names.Where(name => name.Length == 3);
            Console.WriteLine("\nall names whose string length is equal to 3:-");
            foreach (var x in result3)
            {
                Console.Write("{0} ", x);
            }

            var result4 = names.OrderBy(name => name);
            Console.WriteLine("\nall names in Ascending order:-");
            foreach (var x in result4)
            {
                Console.Write("{0} ", x);
            }
            Console.ReadKey();
        }
    }
}
