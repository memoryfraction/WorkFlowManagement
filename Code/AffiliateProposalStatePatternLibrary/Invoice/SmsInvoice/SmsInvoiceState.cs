using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternLibrary.Invoice.SmsInvoice
{
    public class SmsInvoiceState
    {
        protected SmsInvoiceContext _context;
        private SmsInvoiceStatus _status;
        public SmsInvoiceStatus Status { get => _status; set => _status = value; }

        public void SetContext(SmsInvoiceContext context)
        {
            this._context = context;
        }

        public virtual void Submit()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void SmsAuditApprove()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void SmsAuditDecline()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void ClientApprove()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void ClientDecline()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void ClientDispute()
        {
            throw new InvalidOperationException("Invalid Operation");
        }
    }
}
