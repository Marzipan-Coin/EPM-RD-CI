using Epam.ExternalTraining.Abstractions;
using Epam.ExternalTraining.Abstractions.Task1_1;
using Epam.ExternalTraining.Task1.TheMagnificentTen;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace Epam.ExternalTraining.Task1.Tests
{
	public class TriangleTaskTests
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
			var consoleMock = new Mock<IConsole>(MockBehavior.Loose);

			consoleMock.Setup(c => c.ReadLine()).Returns(n.ToString());

			var textWriter = new StringWriter();
			consoleMock.Setup(c => c.WriteLine()).Callback(() => textWriter.WriteLine());
			consoleMock.Setup(c => c.WriteLine(It.IsAny<string>())).Callback<string>((arg) => textWriter.WriteLine(arg));
			consoleMock.Setup(c => c.Write(It.IsAny<string>())).Callback<string>((arg) => textWriter.Write(arg));

			// Act
			_triangleTask.Run(consoleMock.Object);

			// Assert
			textWriter.GetStringBuilder().ToString().Trim().Should().Be(expectedResult);
		}
	}
}