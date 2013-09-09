using ApprovalTests.Asp;
using ApprovalTests.Asp.Mvc;
using ApprovalTests.Reporters;
using IceCream.Mvc.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IceCream.Mvc.Tests.Controllers
{
	[TestClass]
	public class IceCreamFreezerControllerTest : MvcTest
	{
		[TestMethod]
		[UseReporter(typeof(TortoiseDiffReporter))]
		public void TestSimpleView()
		{
			MvcApprovals.VerifyMvcPage(new IceCreamFreezerController().SimpleView);
		}

		[TestMethod]
		[UseReporter(typeof (WinMergeReporter))]
		public void TestIndexView()
		{
			MvcApprovals.VerifyMvcPage(new IceCreamFreezerController().Index);
		}
	}

	public class MvcTest
	{
		public MvcTest()
		{
			PortFactory.MvcPort = 3235;
		}
	}
}
