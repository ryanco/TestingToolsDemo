using ApprovalTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingTools.Tests
{
	[TestClass]
	public class IceCreamFreezerTest
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
