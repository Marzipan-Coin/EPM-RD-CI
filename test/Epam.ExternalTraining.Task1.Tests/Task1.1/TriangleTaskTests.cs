using Epam.ExternalTraining.Abstractions;
using Epam.ExternalTraining.Abstractions.Task1_1;
using Epam.ExternalTraining.Task1.TheMagnificentTen;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Epam.ExternalTraining.Task1.Tests
{
	public class TriangleTaskTests : ConsoleTestBase
	{
		private ITriangleTask _triangleTask;

		[SetUp]
		public void Setup()
		{
			_triangleTask = new TriangleTask();
		}

		#region Test Cases

		public static IEnumerable<TestCaseData> Run_RegularNumbers_ShouldDrawTheTriangle_TestCases()
		{
			yield return new TestCaseData(1, "*");
			yield return new TestCaseData(3, @"*
**
***"); // TODO: different line endings
			yield return new TestCaseData(15, @"*
**
***
****
*****
******
*******
********
*********
**********
***********
************
*************
**************
***************");

		}

		[TestCaseSource(nameof(Run_RegularNumbers_ShouldDrawTheTriangle_TestCases))]
		#endregion
		public void Run_RegularNumbers_ShouldDrawTheTriangle(int n, string expectedResult)
		{
			// Arrange
			SetConsoleInput(n.ToString());
			var outputSb = BindConsoleOutput();

			// Act
			_triangleTask.Run();

			// Assert
			outputSb.ToString().Trim().Should().Be(expectedResult);
		}
	}
}