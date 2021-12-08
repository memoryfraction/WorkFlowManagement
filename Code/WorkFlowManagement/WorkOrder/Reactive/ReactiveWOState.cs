using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowManagement.WorkOrder.Reactive
{
    public class ReactiveWOState
    {

        protected ReactiveWOContext _context;
        private WorkOrderStatus _status;
        public WorkOrderStatus Status { get => _status; set => _status = value; }

        public void SetContext(ReactiveWOContext context)
        {
            this._context = context;
        }

        public virtual void Schedule()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void ApproveDispatch()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void RejectDispatch()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void CheckIn()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void CheckOut()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void Quote()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void ApproveClientQuote()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void RejectClientQuote()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void ApproveVendorQuote()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void RejectVendorQuote()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void CreateVendorInvoice()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void ApproveVendorInvoice()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void DeclineVendorInvoice()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void PayVendor()
        {
            throw new InvalidOperationException("Invalid Operation");
        }

        public virtual void Undo()
        {
            throw new InvalidOperationException("Invalid Operation");
        }
    }
}
