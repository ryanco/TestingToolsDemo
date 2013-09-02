using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApprovalTests;

namespace IceCream.Lib.Tests
{
	[TestClass]
	public class IceCreamApprovalTests
	{
		[TestMethod]
		public void IceCreamApprovalTest()
		{
			var iceCream = new IceCreamProduct
				{
					Name = "Rull Guud",
					Cost = "2.50",
					Flavor = "Bumpin Brogrammer"
				};
			Approvals.Verify(iceCream);
		}
	}
}
