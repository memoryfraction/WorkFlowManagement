using System;
using System.Collections.Generic;
using System.Text;

namespace AffiliateProposalStatePatternLibrary.ConcreteStates
{
    public class ConcreteStateDraft : AffiliateInvoiceState
    {
        public ConcreteStateDraft()
        {
            this.ProposalStatus = ProposalStatus.Draft;
        }
        public override void Approve()
        {
            throw new InvalidOperationException("Draft Proposal can't been approved.");
        }

        public override void Decline()
        {
            throw new InvalidOperationException("Draft Proposal can't been declined.");
        }

        public override void Submit()
        {
            this._context.ChangeStateTo(new ConcreteStateSubmitted());
        }
    }
}
