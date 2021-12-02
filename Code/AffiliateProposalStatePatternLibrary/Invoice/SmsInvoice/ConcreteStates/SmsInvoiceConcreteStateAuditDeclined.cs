﻿using System;

namespace StatePatternLibrary.Invoice.SmsInvoice.ConcreteStates
{
    public class SmsInvoiceConcreteStateAuditDeclined: SmsInvoiceState
    {
        public SmsInvoiceConcreteStateAuditDeclined()
        {
            this.Status = SmsInvoiceStatus.SmsAuditDeclined;
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
