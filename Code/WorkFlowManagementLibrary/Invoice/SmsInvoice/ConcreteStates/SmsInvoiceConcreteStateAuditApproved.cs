using System;

namespace WorkFlowManagementLibrary.Invoice.SmsInvoice.ConcreteStates
{
    public class SmsInvoiceConcreteStateAuditApproved : SmsInvoiceState
    {
        public SmsInvoiceConcreteStateAuditApproved()
        {
            this.Status = SmsInvoiceStatus.SmsAuditApproved;
        }
        public override void SmsAuditApprove()
        {
            throw new InvalidOperationException("Approved Proposal can't be Approved.");
        }

        public override void SmsAuditDecline()
        {
            this._context.ChangeStateTo(new SmsInvoiceConcreteStateAuditDeclined());
        }

        public override void ClientApprove()
        {
            throw new InvalidOperationException("Approved Proposal can't be Approved.");
        }

        public override void ClientDecline()
        {
            this._context.ChangeStateTo(new SmsInvoiceConcreteStateClientDeclined());
        }

        public override void ClientDispute()
        {
            this._context.ChangeStateTo(new SmsInvoiceConcreteStateClientDisputed());
        }

        public override void Submit()
        {
            throw new InvalidOperationException("Approved Proposal can't be Submitted again.");
        }
    }
}
