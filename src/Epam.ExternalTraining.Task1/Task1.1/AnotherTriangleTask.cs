using Epam.ExternalTraining.Abstractions.Task1_1;
using System;

namespace Epam.ExternalTraining.Task1.TheMagnificentTen
{
	public class AnotherTriangleTask : IAnotherTriangleTask
	{
		public void Run()
		{
			//throw new NotImplementedException(); // TODO: remove the task solution
			Console.Write("Enter your credit card number: ");
			if (!int.TryParse(Console.ReadLine(), out var h) || h <= 0)
			{
				Console.WriteLine("Number must be a positive number");
				return;
			}

			// Solution 1 
			for (int i = 0; i < h; i++)
			{
				Console.WriteLine(new string(' ', h - i - 1) + new string('*', 1 + i * 2));
			}
		}
	}

}
