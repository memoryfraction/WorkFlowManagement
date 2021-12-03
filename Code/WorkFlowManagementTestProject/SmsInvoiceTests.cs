using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatePatternLibrary.Invoice.SmsInvoice;
using StatePatternLibrary.Invoice.SmsInvoice.ConcreteStates;
using System;

namespace StatePatternTestProject
{
    [TestClass]
    public class SmsInvoiceTests
    {
        [TestMethod]
        public void TestMethodDraftSubmitted()
        {
            // Arrange
            var context = new SmsInvoiceContext(new SmsInvoiceConcreteStateDraft());
            // Act
            context.State.Submit();
            // Assert
            Assert.AreEqual(SmsInvoiceStatus.SubmittedForSmsAudit, context.State.Status);
        }

        [TestMethod]
        public void TestMethodDraftMultipleWorkFlows()
        {
            // Arrange
            var context = new SmsInvoiceContext(new SmsInvoiceConcreteStateDraft());

            // Act
            context.State.Submit();
            context.State.SmsAuditDecline();
            Assert.AreEqual(SmsInvoiceStatus.SmsAuditDeclined, context.State.Status);

            context.State.ClientApprove();
            Assert.AreEqual(SmsInvoiceStatus.ClientApproved, context.State.Status);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Approved Proposal can't be Submitted again.")]
        public void InvalidOperationShouldThrowException()
        {
            // Arrange
            var context = new SmsInvoiceContext(new SmsInvoiceConcreteStateDraft());
            // Act
            context.State.Submit();
            context.State.ClientDecline();
            context.State.SmsAuditApprove();
            context.State.SmsAuditApprove();
        }
    }
}
