using System;

namespace StatePatternLibrary.ConcreteStates
{
    public class AffiliateInvoiceConcreteStateDeclined : AffiliateInvoiceState
    {

        public AffiliateInvoiceConcreteStateDeclined()
        {
            this.Status = AffiliateInvoiceStatus.Declined;
        }

        public override void Approve()
        {
            this._context.ChangeStateTo(new AffiliateInvoiceConcreteStateApproved());
        }

        public override void Decline()
        {
            throw new InvalidOperationException("Declined Proposal can't been declined.");
        }

        public override void Submit()
        {
            throw new InvalidOperationException("Submitted Proposal can't been submitted.");
        }
    }
}
