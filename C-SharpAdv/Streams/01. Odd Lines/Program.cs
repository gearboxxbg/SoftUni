using System;
using System.IO;

	class Program
	{
		static void Main(string[] args)
		{
			using (var stream = new StreamReader(@"C:\Users\Gearboxx\Desktop\repository\SoftUni\C-SharpAdv\Streams\01. Odd Lines\text.txt"))
			{
				var lineNumber = 1;
				string line;

				while ((line = stream.ReadLine()) != null)
				{
					if (lineNumber % 2 == 0)
					{

						Console.WriteLine(line);

					}

					lineNumber++;
				}
			}
		}
	}