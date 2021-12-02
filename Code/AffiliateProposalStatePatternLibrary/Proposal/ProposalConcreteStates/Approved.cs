using System;

namespace AffiliateProposalStatePatternLibrary.ConcreteStates
{
    public class ProposalConcreteStateApproved : ProposalState
    {
        public ProposalConcreteStateApproved()
        {
            this.ProposalStatus = ProposalStatus.Approved;
        }
        public override void Approve()
        {
            throw new InvalidOperationException("Approved Proposal can't been Approved.");
        }

        public override void Decline()
        {
            this._context.ChangeStateTo(new ProposalConcreteStateDeclined());
        }

        public override void Submit()
        {
            throw new InvalidOperationException("Approved Proposal can't been Submitted.");
        }
    }

}
