using ApprovalTests.Asp;
using ApprovalTests.Asp.Mvc;
using ApprovalTests.Reporters;
using IceCream.Mvc.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IceCream.Mvc.Tests.Controllers
{
	[TestClass]
	public class IceCreamFreezerControllerTest
	{
		[TestMethod]
		[UseReporter(typeof(TortoiseDiffReporter))]
		public void TestSimpleView()
		{
			PortFactory.MvcPort = 3235;
			MvcApprovals.VerifyMvcPage(new IceCreamFreezerController().SimpleView);
		}
	}
}
