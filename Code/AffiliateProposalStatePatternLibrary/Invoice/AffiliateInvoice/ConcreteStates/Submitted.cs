using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternLibrary.ConcreteStates
{

    public class AffiliateInvoiceConcreteStateSubmitted : AffiliateInvoiceState
    {
        public AffiliateInvoiceConcreteStateSubmitted()
        {
            this.Status = AffiliateInvoiceStatus.Submitted;
        }

        public override void Approve()
        {
            this._context.ChangeStateTo(new AffiliateInvoiceConcreteStateApproved());
        }

        public override void Decline()
        {
            this._context.ChangeStateTo(new AffiliateInvoiceConcreteStateDeclined());
        }

        public override void Submit()
        {
            throw new InvalidOperationException("Submitted Proposal can't been submitted again.");
        }
    }

}
