using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace TestLogicForSite.UnitTest
{
	// This project can output the Class library as a NuGet Package.
	// To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
	public class MagicUnitTest
	{
		private Magic Magic = new Magic();

		[Fact]
		public void PositeveTest()
		{
			Assert.True(this.Magic.Positive());
		}

		[Fact]
		public void NegativeTest()
		{
			//Assert.True(this.Magic.Negative());
		}

		[Fact]
		public void TestPackagesRestore()
		{
			Matrix<double> A = DenseMatrix.OfArray(new double[,] {
		{1,1,1,1},
		{1,2,3,4},
		{4,3,2,1}});
			Vector<double>[] nullspace = A.Kernel();

			// verify: the following should be approximately (0,0,0)
			Vector<double> result = (A * (2 * nullspace[0] - 3 * nullspace[1]));
		}
	}
}
