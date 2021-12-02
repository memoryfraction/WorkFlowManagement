using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatePatternLibrary;
using StatePatternLibrary.ConcreteStates;
using System;

namespace StatePatternTestProject
{
    [TestClass]
    public class AffiliateInvoiceTests
    {

        [TestMethod]
        public void TestMethodDraftSubmitted()
        {
            // Arrange
            var context = new AffiliateInvoiceContext(new AffiliateInvoiceConcreteStateDraft());

            // Act
            context.State.Submit();

            // Assert
            Assert.AreEqual(AffiliateInvoiceStatus.Submitted, context.State.Status);
        }

        [TestMethod]
        public void TestMethodDraftMultipleWorkFlows()
        {
            // Arrange
            var context = new AffiliateInvoiceContext(new AffiliateInvoiceConcreteStateDraft());

            // Act
            context.State.Submit();
            context.State.Decline();
            context.State.Approve();

            // Assert
            Assert.AreEqual(AffiliateInvoiceStatus.Approved, context.State.Status);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Approved Proposal can't be Submitted again.")]
        public void InvalidOperationShouldThrowException()
        {
            // Arrange
            var context = new AffiliateInvoiceContext(new AffiliateInvoiceConcreteStateDraft());

            // Act
            context.State.Submit();
            context.State.Decline();
            context.State.Approve();
            context.State.Submit();
        }

    }
}
