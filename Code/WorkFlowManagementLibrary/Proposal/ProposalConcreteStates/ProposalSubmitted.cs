using System;

namespace WorkFlowManagementLibrary.ConcreteStates
{
    public class ProposalConcreteStateSubmitted : ProposalState
    {
        public ProposalConcreteStateSubmitted()
        {
            this.ProposalStatus = ProposalStatus.Submitted;
        }

        public override void Approve()
        {
            this._context.ChangeStateTo(new ProposalConcreteStateApproved());
        }

        public override void Decline()
        {
            this._context.ChangeStateTo(new ProposalConcreteStateDeclined());
        }

        public override void PreApprove()
        {
            this._context.ChangeStateTo(new ProposalConcreteStatePreApprove());
        }

        public override void Submit()
        {
            throw new InvalidOperationException("Submitted Proposal can't be submitted again.");
        }
    }

}
