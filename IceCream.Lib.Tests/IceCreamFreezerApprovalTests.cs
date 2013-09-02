using ApprovalTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IceCream.Lib.Tests
{
	[TestClass]
	public class IceCreamFreezerApprovalTests
	{
		[TestMethod]
		public void AddToFreezerApprovalTest()
		{
			var freezer = new IceCreamFreezer();
			freezer.AddIceCream(new IceCream { Name = "Tastey" });
			freezer.AddIceCream(new IceCream { Name = "Lite" });

			Approvals.VerifyAll("Freezer Contents Test:", freezer.Contents(), "Ice Cream");
		}
	}
}
