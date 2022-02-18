using System;

namespace WorkFlowManagementLibrary.Invoice.SmsInvoice.ConcreteStates
{
    public class SmsInvoiceConcreteStateClientDisputed : SmsInvoiceState
    {
        public SmsInvoiceConcreteStateClientDisputed()
        {
            this.Status = SmsInvoiceStatus.ClientDisputed;
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
            this._context.ChangeStateTo(new SmsInvoiceConcreteStateClientApproved());
        }

        public override void ClientDecline()
        {
            this._context.ChangeStateTo(new SmsInvoiceConcreteStateClientDeclined());
        }



        public override void Submit()
        {
            this._context.ChangeStateTo(new SmsInvoiceConcreteStateSubmitted());
        }
    }
}
