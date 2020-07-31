using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Addition;
namespace ConsoleAppLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition.Addition A = new Addition.Addition();
            Console.WriteLine(A.Add(15, 20));
        }
    }
}
