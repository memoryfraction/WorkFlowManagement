using System;

namespace StatePatternLibrary.ConcreteStates
{
    public class AffiliateInvoiceConcreteStateDraft : AffiliateInvoiceState
    {
        public AffiliateInvoiceConcreteStateDraft()
        {
            this.Status = AffiliateInvoiceStatus.Draft;
        }
        public override void Approve()
        {
            throw new InvalidOperationException("Draft Proposal can't be approved.");
        }

        public override void Decline()
        {
            throw new InvalidOperationException("Draft Proposal can't be declined.");
        }

        public override void Submit()
        {
            this._context.ChangeStateTo(new AffiliateInvoiceConcreteStateSubmitted());
        }
    }
}
