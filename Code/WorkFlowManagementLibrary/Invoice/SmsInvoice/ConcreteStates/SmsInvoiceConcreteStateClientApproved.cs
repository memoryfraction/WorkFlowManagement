using System;

namespace WorkFlowManagementLibrary.Invoice.SmsInvoice.ConcreteStates
{
    public class SmsInvoiceConcreteStateClientApproved : SmsInvoiceState
    {
        public SmsInvoiceConcreteStateClientApproved()
        {
            this.Status = SmsInvoiceStatus.ClientApproved;
        }

        public override void SmsAuditApprove()
        {
            this._context.ChangeStateTo(new SmsInvoiceConcreteStateAuditApproved());
        }

        public override void SmsAuditDecline()
        {
            this._context.ChangeStateTo(new SmsInvoiceConcreteStateAuditDeclined());
        }

        public override void ClientApprove()
        {
            throw new InvalidOperationException("ClientApproved Invoice can't be Approved again.");
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
            throw new InvalidOperationException("ClientApproved Invoice can't be Submitted.");
        }
    }
}
