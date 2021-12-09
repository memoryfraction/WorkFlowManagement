using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkFlowManagement.WorkOrder;
using WorkFlowManagement.WorkOrder.Reactive;
using WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates;

namespace WorkFlowManagementTestProject
{
    [TestClass]
    public class ReactiveWOTests
    {
        [TestMethod]
        public void TestMethod_ClientQuoteApproved_Should_Work()
        {
            // Arrange
            var context = new ReactiveWOContext(new ReactiveWorkOrderPendingDispatch());

            // Act
            context.State.Dispatch();
            context.State.Schedule();
            context.State.CheckIn();
            context.State.CheckOut(WorkOrderStatus.PendingVendorQuote);
            context.State.AffiliateEntersQuote();
            context.State.ApprovePendingClientQuote();
            context.State.RejectClientQuote();
            context.State.RejectVendorQuote();
            context.State.AffiliateEntersQuote();
            context.State.ApprovePendingClientQuote();
            context.State.ApproveClientQuote();

            // Assert
            Assert.AreEqual(WorkOrderStatus.QuoteApproved, context.State.Status);
        }


        [TestMethod]
        public void TestMethod_VendorPaid_Branch_Should_Work()
        {
            // Arrange
            var context = new ReactiveWOContext(new ReactiveWorkOrderPendingDispatch());

            // Act
            context.State.Dispatch();
            context.State.Schedule();
            context.State.CheckIn();
            context.State.CheckOut(WorkOrderStatus.WorkCompletePendingVendorInvoice);
            context.State.AffiliateCreatesInvoice();
            context.State.RejectVendorInvoice();
            context.State.AffiliateCreatesInvoice();
            context.State.ApproveVendorInvoice();
            context.State.Bill();
            context.State.PayVendor();

            // Assert
            Assert.AreEqual(WorkOrderStatus.VendorPaid, context.State.Status);
        }

    }
}
