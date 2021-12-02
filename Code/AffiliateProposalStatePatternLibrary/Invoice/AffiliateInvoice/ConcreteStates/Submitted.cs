using System;
using System.Collections.Generic;
using System.Text;

namespace AffiliateProposalStatePatternLibrary.ConcreteStates
{

    public class ConcreteStateSubmitted : AffiliateInvoiceState
    {
        public ConcreteStateSubmitted()
        {
            this.ProposalStatus = ProposalStatus.Submitted;
        }

        public override void Approve()
        {
            this._context.ChangeStateTo(new ConcreteStateApproved());
        }

        public override void Decline()
        {
            this._context.ChangeStateTo(new ConcreteStateDeclined());
        }

        public override void Submit()
        {
            throw new InvalidOperationException("Submitted Proposal can't been submitted again.");
        }
    }

}
