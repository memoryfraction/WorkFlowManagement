using System;
using System.Collections.Generic;
using System.Text;

namespace AffiliateProposalStatePatternLibrary.ConcreteStates
{
    public class ConcreteStateDraft : ProposalState
    {
        public ConcreteStateDraft()
        {
            this.ProposalStateType = ProposalStateType.Draft;
        }
        public override void Approve()
        {
            Console.WriteLine("Draft Proposal can't been approved.");
        }

        public override void Decline()
        {
            Console.WriteLine("Draft Proposal can't been declined.");
        }

        public override void Submit()
        {
            this._context.ChangeStateTo(new ConcreteStateSubmitted());
        }
    }
}
