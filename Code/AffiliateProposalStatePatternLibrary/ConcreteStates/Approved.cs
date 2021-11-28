using System;

namespace AffiliateProposalStatePatternLibrary.ConcreteStates
{
    public class ConcreteStateApproved : ProposalState
    {
        public ConcreteStateApproved()
        {
            this.ProposalStatus = ProposalStatus.Approved;
        }
        public override void Approve()
        {
            Console.WriteLine("Approved Proposal can't been Approved.");
        }

        public override void Decline()
        {
            this._context.ChangeStateTo(new ConcreteStateDeclined());
        }

        public override void Submit()
        {
            Console.WriteLine("Approved Proposal can't been Submitted.");
        }
    }

}
