using Epam.ExternalTraining.Abstractions.Task1_1;
using System;

namespace Epam.ExternalTraining.Task1.TheMagnificentTen
{
	public class SumOfNumbersTask : ISumOfNumbersTask
	{
		public void Run()
		{
			//throw new NotImplementedException(); // TODO: remove the task solution
			Console.Write("Enter your credit card number: ");
			if (!int.TryParse(Console.ReadLine(), out var max) || max <= 0)
			{
				Console.WriteLine("Number must be a positive number");
				return;
			}

			// Solution 1 
			var sumFor3 = GetArithmeticSeries(3, 3, (max-1)/3);
			var sumFor5 = GetArithmeticSeries(5, 5, (max-1)/5);
			var sumFor15 = GetArithmeticSeries(15, 15, (max-1)/15);

			Console.WriteLine(sumFor3 + sumFor5 - sumFor15);

			// Solution 2
			long sum = 0;
			for (int i = 3; i < max; i++)
				if (i % 3 == 0 || i % 5 == 0) sum += i;

			Console.WriteLine(sum);
		}

		private long GetArithmeticSeries(long a1, long d, long n) => ( (2*a1) + (n-1)*d ) * n / 2;
	}
}
