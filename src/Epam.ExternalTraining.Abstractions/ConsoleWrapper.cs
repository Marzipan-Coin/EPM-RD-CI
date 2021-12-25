using System;

namespace Epam.ExternalTraining.Abstractions
{
	public class ConsoleWrapper : IConsole // TODO: probably should go to entities assembly
	{
		public string ReadLine() => Console.ReadLine();
		public void WriteLine(string output) => Console.WriteLine(output);
	}

}
