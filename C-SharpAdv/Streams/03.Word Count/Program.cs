﻿using System;
using System.IO;
using System.Linq;

namespace _03.Word_Count
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var readStreamtext = new StreamReader(@"D:\CSharpAdvance\C-SharpAdvanced\Streams\Streams-Exercise\text.txt"))
			{
				using (var readStreamword = new StreamReader(@"D:\CSharpAdvance\C-SharpAdvanced\Streams\03.Word Count\words.txt"))
				{
					using (var writeStream = new StreamWriter(@"D:\CSharpAdvance\C-SharpAdvanced\Streams\03.Word Count\broi.txt"))
					{
						using (var readStreamword2 = new StreamReader(@"D:\CSharpAdvance\C-SharpAdvanced\Streams\03.Word Count\word.txt"))
						{
							string a = readStreamword.ReadLine();
							string b = readStreamword.ReadLine();
							string c = readStreamword.ReadLine();
							string a1 = readStreamword2.ReadLine();
							string b1 = readStreamword2.ReadLine();
							string c1 = readStreamword2.ReadLine();
							int sum1 = 0, sum2 = 0, sum3 = 0;
							string line;

							while ((line = readStreamtext.ReadLine()) != null)
							{
								line = line.ToLower();
								string[] input = line.Split(" ");

								for (int i = 0; i < input.Length; i++)
								{
									if (a == input[i] || a1 == input[i])
									{
										sum1++;
									}

									if (b == input[i] || b1 == input[i])
									{
										sum2++;
									}
									if (c == input[i] || c1 == input[i])
									{
										sum3++;
									}
								}
							}

							Console.WriteLine(sum1);
							Console.WriteLine(sum2);
							Console.WriteLine(sum3);

							if (sum1 > sum2 && sum1 > sum3)
							{
								writeStream.WriteLine(a + " - " + sum1);
								if (sum2 > sum3)
								{
									writeStream.WriteLine(b + " - " + sum2);
									writeStream.WriteLine(c + " - " + sum3);
								}
								else
								{
									writeStream.WriteLine(c + " - " + sum3);
									writeStream.WriteLine(b + " - " + sum2);
								}
							}
							else if (sum2 > sum1 && sum2 > sum3)
							{
								writeStream.WriteLine(b + " - " + sum2);
								if (sum1 > sum3)
								{
									writeStream.WriteLine(a + " - " + sum1);
									writeStream.WriteLine(c + " - " + sum3);
								}
								else
								{
									writeStream.WriteLine(c + " - " + sum3);
									writeStream.WriteLine(a + " - " + sum1);
								}
							}
							else
							{
								writeStream.WriteLine(a + " - " + sum1);
								writeStream.WriteLine(b + "  -" + sum2);
								writeStream.WriteLine(c + " - " + sum3);
							}
						}
					}
				}
			}
		}
	}
}
