using System;

namespace StatePatternLibrary.ConcreteStates
{
    public class ProposalConcreteStateDraft : ProposalState
    {
        public ProposalConcreteStateDraft()
        {
            this.ProposalStatus = ProposalStatus.Draft;
        }
        public override void Approve()
        {
            throw new InvalidOperationException("Draft Proposal can't be approved.");
        }

        public override void Decline()
        {
            throw new InvalidOperationException("Draft Proposal can't be declined.");
        }

        public override void Submit()
        {
            this._context.ChangeStateTo(new ProposalConcreteStateSubmitted());
        }

        public override void PreApprove()
        {
            throw new InvalidOperationException("Draft Proposal can't be PreApproved.");
        }
    }
}
