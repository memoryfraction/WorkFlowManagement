using System;

namespace StatePatternLibrary.ConcreteStates
{
    public class ProposalConcreteStateDeclined : ProposalState
    {
        public ProposalConcreteStateDeclined()
        {
            this.ProposalStatus = ProposalStatus.Declined;
        }

        public override void Approve()
        {
            this._context.ChangeStateTo(new ProposalConcreteStateApproved());
        }

        public override void Decline()
        {
            throw new InvalidOperationException("Declined Proposal can't be declined.");
        }

        public override void Submit()
        {
            throw new InvalidOperationException("Declined Proposal can't be submitted.");
        }

        public override void PreApprove()
        {
            throw new InvalidOperationException("Declined Proposal can't be PreApproved.");
        }
    }
}
