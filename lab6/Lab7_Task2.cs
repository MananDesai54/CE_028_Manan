// Author : Dhruv B Kakadiya
using System;
using System.Linq;
using System.Collections.Generic;
namespace Lab7_Task2
{
	public class Task2
	{
		static void Main(string []args)
		{
			string[] names = {"Dz", "Elon", "Jeff", "Kylie", "Bill", "kevin", "Joy", "Jack", "Stephen", "Albert"};
			var start_with_k = names.Where(n => n[0] == 'K' || n[0] == 'k');
			var length_less_than_4 = names.Where(n => n.Length < 4);
			var length_equal_3 = names.Where(n => n.Length == 3);
			var ascending = names.OrderBy(n => n);

			Console.WriteLine("Name Starts with k : ");
			foreach(var i in start_with_k)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine();
			Console.WriteLine("Names Whose length is less than 4 : ");
			foreach(var i in length_less_than_4)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine();
			Console.WriteLine("Names Whose length is equalto 3 : ");
			foreach(var i in length_equal_3)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine();
			Console.WriteLine("Names in ascending Order : ");
			foreach(var i in ascending)
			{
				Console.WriteLine(i);
			}
			Console.ReadLine();
		}
	}
}