using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

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
			Assert.True(this.Magic.PositiveTest());
		}

		[Fact]
		public void NegativeTest()
		{
			Assert.True(this.Magic.NegativeTest());
		}
	}
}
