using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatePatternLibrary;
using StatePatternLibrary.ConcreteStates;
using System;

namespace StatePatternTestProject
{
    [TestClass]
    public class ProposalUnitTests
    {
        [TestMethod]
        public void TestMethodDraftSubmitted()
        {
            // Arrange
            var proposalContext = new ProposalContext(new ProposalConcreteStateDraft());

            // Act
            proposalContext.State.Submit();

            // Assert
            Assert.AreEqual(ProposalStatus.Submitted, proposalContext.State.ProposalStatus);
        }

        [TestMethod]
        public void TestMethodDraftMultipleWorkFlows()
        {
            // Arrange
            var proposalContext = new ProposalContext(new ProposalConcreteStateDraft());

            // Act
            proposalContext.State.Submit();
            proposalContext.State.PreApprove();
            proposalContext.State.Decline();
            proposalContext.State.Approve();

            // Assert
            Assert.AreEqual(ProposalStatus.Approved, proposalContext.State.ProposalStatus);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Approved Proposal can't be Submitted again.")]
        public void TestMethodShouldThrowException()
        {
            // Arrange
            var proposalContext = new ProposalContext(new ProposalConcreteStateDraft());

            // Act
            proposalContext.State.Submit();
            proposalContext.State.Decline();
            proposalContext.State.Approve();
            proposalContext.State.Submit();
        }
    }
}
