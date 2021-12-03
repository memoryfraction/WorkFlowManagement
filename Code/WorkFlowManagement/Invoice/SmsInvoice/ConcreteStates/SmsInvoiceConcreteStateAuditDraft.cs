using System;

namespace StatePatternLibrary.Invoice.SmsInvoice.ConcreteStates
{
    public class SmsInvoiceConcreteStateDraft: SmsInvoiceState
    {
        public SmsInvoiceConcreteStateDraft()
        {
            this.Status = SmsInvoiceStatus.Draft;
        }

        public override void SmsAuditApprove()
        {
            throw new InvalidOperationException("Draft Proposal can't be Approved.");
        }

        public override void SmsAuditDecline()
        {
            throw new InvalidOperationException("Draft Proposal can't be declined.");
        }

        public override void ClientApprove()
        {
            throw new InvalidOperationException("Draft Proposal can't be approved.");
        }

        public override void ClientDecline()
        {
            throw new InvalidOperationException("Draft Proposal can't be declined.");
        }

        public override void ClientDispute()
        {
            this._context.ChangeStateTo(new SmsInvoiceConcreteStateClientDisputed());
        }

        public override void Submit()
        {
            this._context.ChangeStateTo(new SmsInvoiceConcreteStateSubmitted());
        }

    }
}
