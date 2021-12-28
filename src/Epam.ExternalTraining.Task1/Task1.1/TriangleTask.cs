using Epam.ExternalTraining.Abstractions;
using Epam.ExternalTraining.Abstractions.Task1_1;
using System;

namespace Epam.ExternalTraining.Task1.TheMagnificentTen
{
	public class TriangleTask : ITriangleTask
	{
		public void Run()
		{
			//throw new NotImplementedException(); // TODO: remove the task solution

			if (!int.TryParse(Console.ReadLine(), out var h) || h <= 0)
			{
				Console.WriteLine("Number must be a positive number");
				return;
			}

			// Solution 1 
			//for (int i = 1; i <= h; i++)
			//	Console.WriteLine(new string('*', i));

			// Solution 2
			//for (int i = 1; i <= h; i++)
			//{
			//	for (int width = 0; width < i; width++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			// Solution 3 (char)
			for (int i = 1; i <= h; i++)
			{
				for (int width = 0; width < i; width++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}

}
