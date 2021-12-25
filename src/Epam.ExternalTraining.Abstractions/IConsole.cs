using System.Collections.Generic;
using System.Text;

namespace Epam.ExternalTraining.Abstractions
{
	public interface IConsole
	{
		string ReadLine();
		void WriteLine(string output);

		// TODO: this can limit creativity (Write method doesn't exist)
	}
}
