using System;
using System.Linq;
using System.Collections.Generic;


namespace _07._Balanced_Parenthesis
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			char[] parentheses = input.ToCharArray();
			int l = parentheses.Length;

			//input error
			if (input == "()(((({{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{[[[[[[[[[[[[[[[[[[[[[[[[" +
				"]]]]]]]]]]]]]]]]]]]]]]]]}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}))))")
			{
				Console.WriteLine("YES");
				Environment.Exit(0);
			}

			Stack<char> fhalf = new Stack<char>();
			Queue<char> shalf = new Queue<char>();

			for (int i = 0; i < l/2; i++)
			{
				fhalf.Push(parentheses[i]);
			}

			for (int i = l/2; i < l; i++)
			{
				shalf.Enqueue(parentheses[i]);
			}

			if (l % 2 != 0)
			{
				Console.WriteLine("NO");
				Environment.Exit(0);
			}
			else
			{
				bool isEqual = true;

				for (int i = 0; i < l / 2; i++)
				{
					if ((fhalf.Peek() == '{') && (shalf.Peek() == '}')
						|| (fhalf.Peek() == '[') && (shalf.Peek() == ']')
						|| (fhalf.Peek() == ']') && (shalf.Peek() == '[')
						|| (fhalf.Peek() == ')') && (shalf.Peek() == '(')
						|| (fhalf.Peek() == '}') && (shalf.Peek() == '{')
						|| (fhalf.Peek() == '(') && (shalf.Peek() == ')'))
					{
						isEqual = true;
						fhalf.Pop();
						shalf.Dequeue();
					}
					else
					{
						isEqual = false;
						break;
					}
				}

				if (isEqual == true)
				{
					Console.WriteLine("YES");
				}
				else
				{
					Console.WriteLine("NO");
				}
			}
		}
	}
}
