using System;
using ApprovalTests;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingTools.Tests
{
    [TestClass]
    public class IceCreamFreezerTest
    {
        [TestMethod]
        [UseReporter(typeof(WinMergeReporter))]
        public void AddToFreezerTest()
        {
            var freezer = new IceCreamFreezer();
            freezer.AddIceCream(new IceCream("Tastey"));
            freezer.AddIceCream(new IceCream("Lite"));

            Approvals.VerifyAll(freezer.Contents(), "Name");
        }
    }
}
