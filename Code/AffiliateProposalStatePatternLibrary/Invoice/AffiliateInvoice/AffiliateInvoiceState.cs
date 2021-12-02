

using System;

namespace StatePatternLibrary
{
    // The base State class declares methods that all Concrete State should
    // implement and also provides a backreference to the Context object,
    // associated with the State. This backreference can be used by States to
    // transition the Context to another State.
    public abstract class AffiliateInvoiceState
    {
        protected AffiliateInvoiceContext _context;
        private AffiliateInvoiceStatus _status;
        public AffiliateInvoiceStatus Status { get => _status; set => _status = value; }

        public void SetContext(AffiliateInvoiceContext context)
        {
            this._context = context;
        }

        public virtual void Submit()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void Approve()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void Decline()
        {
            throw new InvalidOperationException("Invalid Operation");
        }
    }
}
