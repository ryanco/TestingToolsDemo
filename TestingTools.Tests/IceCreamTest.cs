using System;
using ApprovalTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingTools.Tests
{
	[TestClass]
	public class IceCreamTest
	{
		[TestMethod]
		public void IceCreamApprovalsTest()
		{
			var iceCream = new IceCream()
				{
					Name = "Rull Guud",
					Cost = 2.50,
					Flavor = "Bumpin Brogrammer"
				};
			Approvals.Verify(iceCream);
		}
	}
}
