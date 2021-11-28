using System;

namespace AffiliateProposalStatePatternLibrary.ConcreteStates
{
    public class ConcreteStateDeclined : ProposalState
    {

        public ConcreteStateDeclined()
        {
            this.ProposalStatus = ProposalStatus.Declined;
        }

        public override void Approve()
        {
            this._context.ChangeStateTo(new ConcreteStateApproved());
        }

        public override void Decline()
        {
            Console.WriteLine("Declined Proposal can't been declined.");
        }

        public override void Submit()
        {
            Console.WriteLine("Submitted Proposal can't been submitted.");
        }
    }
}
