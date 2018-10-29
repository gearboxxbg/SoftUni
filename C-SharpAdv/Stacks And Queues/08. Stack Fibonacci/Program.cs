using System;
using System.Collections.Generic;

namespace _08._Stack_Fibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Stack<long> fibb = new Stack<long>();
			fibb.Push(0);
			fibb.Push(1);

			for (int i = 0; i < n - 1; i++)
			{
				long x = fibb.Peek();
				fibb.Pop();
				long y = fibb.Peek();

				fibb.Push(x);
				fibb.Push(x + y);
			}

			Console.WriteLine(fibb.Peek());
		}
	}
}
