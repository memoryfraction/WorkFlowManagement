

using System;
using WorkFlowManagement.WorkOrder;

namespace WorkFlowManagement.WorkOrder
{
    // The base State class declares methods that all Concrete State should
    // implement and also provides a backreference to the Context object,
    // associated with the State. This backreference can be used by States to
    // transition the Context to another State.
    public abstract class RecurrentWOState
    {
        protected RecurrentWOContext _context;
        private WorkOrderStatus _status;
        public WorkOrderStatus Status { get => _status; set => _status = value; }

        public void SetContext(RecurrentWOContext context)
        {
            this._context = context;
        }

        public virtual void Schedule()
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

        public virtual void BatchInvoice()
        {
            throw new InvalidOperationException("Invalid Operation");
        }
        public virtual void PaytoAffiliate()
        {
            throw new InvalidOperationException("Invalid Operation");
        }
        public virtual void Undo()
        {
            throw new InvalidOperationException("Invalid Operation");
        }
    }
}
