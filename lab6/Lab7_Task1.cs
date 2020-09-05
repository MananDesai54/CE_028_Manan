// Author : Dhruv B kakadiya
using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab7_Task1
{
	public class Task1
	{
		static void Main(string []args)
		{
			int[] number = new int[100];
			for(int i = 0 ; i < 100 ; i++)
			{
				number[i] = i + 1;
			}
			var even = number.Where(n => n % 2 == 0);
			var odd = number.Where(n => n % 2 == 1);
			var all = number.Select(n => n);
			var max = number.Max();
			var min = number.Min();
			var avg = number.Average();
			Console.Write("Even Numbers are :- \n");
			foreach(var i in even)
			{
				Console.Write(i);
				Console.Write(" ");
			}
			Console.WriteLine("\n\n");
			Console.Write("Odd Numbers are :- \n");
			foreach(var i in odd)
			{
				Console.Write(i);
				Console.Write(" ");
			}
			Console.WriteLine("\n\n");
			Console.Write("All Numbers are :- ");
			foreach(var i in all)
			{
				Console.Write(i);
				Console.Write(" ");
			}
			Console.WriteLine("\n\n");
			Console.WriteLine($"Max Number is {max}\n");
			Console.WriteLine($"Min Number is {min}\n");
			Console.WriteLine($"Avrage is {avg}\n");
			Console.ReadLine();
		}
	}
}