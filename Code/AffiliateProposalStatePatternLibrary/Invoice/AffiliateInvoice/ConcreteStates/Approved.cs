using System;

namespace StatePatternLibrary.ConcreteStates
{
    public class AffiliateInvoiceConcreteStateApproved : AffiliateInvoiceState
    {
        public AffiliateInvoiceConcreteStateApproved()
        {
            this.Status = AffiliateInvoiceStatus.Approved;
        }
        public override void Approve()
        {
            throw new InvalidOperationException("Approved Proposal can't been Approved.");
        }

        public override void Decline()
        {
            this._context.ChangeStateTo(new AffiliateInvoiceConcreteStateDeclined());
        }

        public override void Submit()
        {
            throw new InvalidOperationException("Approved Proposal can't been Submitted.");
        }
    }

}
