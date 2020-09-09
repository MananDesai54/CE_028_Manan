using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number=new int[100];
            for(int i = 0; i < 100; i++)
            {
                number[i] = i + 1;
            }
            
            var even = number.Where(num => num % 2 == 0);
            Console.WriteLine("Even Numbers:- ");
            foreach(var x in even)
            {
                Console.Write("{0} ",x);
            }
            
            Console.WriteLine("\n\nOdd Numbers:- ");
            var odd = number.Where(num => num % 2 != 0);
            foreach (var x in odd)
            {
                Console.Write("{0} ", x);
            }

            Console.WriteLine("\n\nAll Numbers:- ");
            var all = number.Select(num => num);
            foreach (var x in all)
            {
                Console.Write("{0} ", x);
            }

            var max = number.Max();
            Console.WriteLine("\n\nMaximum Number is:- {0}",max);
            
            var min = number.Min();
            Console.WriteLine("\nMinimum Number is:- {0}", min);
            
            var avg = number.Average();
            Console.WriteLine("\nAverage Number is:- {0}", avg);
            Console.ReadKey();
        }
    }
}
