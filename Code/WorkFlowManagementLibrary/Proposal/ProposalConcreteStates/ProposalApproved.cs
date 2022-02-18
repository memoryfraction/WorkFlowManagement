using System;

namespace WorkFlowManagementLibrary.ConcreteStates
{
    public class ProposalConcreteStateApproved : ProposalState
    {
        public ProposalConcreteStateApproved()
        {
            this.ProposalStatus = ProposalStatus.Approved;
        }
        public override void Approve()
        {
            throw new InvalidOperationException("Approved Proposal can't be Approved.");
        }

        public override void Decline()
        {
            this._context.ChangeStateTo(new ProposalConcreteStateDeclined());
        }

        public override void Submit()
        {
            throw new InvalidOperationException("Approved Proposal can't be Submitted.");
        }

        public override void PreApprove()
        {
            throw new InvalidOperationException("Approved Proposal can't be PreApproved again.");
        }
    }

}
