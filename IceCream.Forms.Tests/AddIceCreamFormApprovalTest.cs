using ApprovalTests.Reporters;
using ApprovalTests.WinForms;
using IceCream.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IceCream.Forms.Tests
{
	[TestClass]
	public class AddIceCreamFormApprovalTest
	{
		[TestMethod]
		[UseReporter(typeof(ClipboardReporter), typeof(TortoiseImageDiffReporter))]
		public void TestInitializationOfForm()
		{
			var form = new AddIceCreamForm();
			WinFormsApprovals.Verify(form);

		}

		[TestMethod]
		[UseReporter(typeof (ClipboardReporter), typeof (TortoiseImageDiffReporter))]
		public void TestAddingIceCream()
		{
			var form = new AddIceCreamForm();
			var iceCream = new IceCreamProduct
				{
					Name = "Fatty Cake",
					Cost = "2.50",
					Flavor = "Big Haus"
				};
			form.AddIceCreamToFreezer(iceCream);
			WinFormsApprovals.Verify(form);

		}
		
	}
}
