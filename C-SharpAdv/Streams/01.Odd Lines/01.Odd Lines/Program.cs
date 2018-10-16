using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd
{
	class Program
	{
		static void Main(string[] args)
		{

			string[] file = File.ReadAllLines("input.txt");

			for (int i = 0; i < file.Length; i++)
			{
				if (i % 2 == 1)
				{
					//File.AppendAllText("output.txt",file[i] + "\r\n");

					Console.WriteLine(string.Join("output.txt", file[i]));
				}
			}
			//  Console.ReadLine();
			//  Console.ReadLine();
		}
	}
}