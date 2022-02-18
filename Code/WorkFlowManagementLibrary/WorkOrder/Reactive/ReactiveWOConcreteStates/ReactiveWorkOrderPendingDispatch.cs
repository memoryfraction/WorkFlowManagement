using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderPendingDispatch: ReactiveWOState
    {
        public ReactiveWorkOrderPendingDispatch()
        {
            this.Status = WorkOrderStatus.PendingDispatch;
        }

        public override void Dispatch()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderPendingVendorAcceptance());
        }
    }
}
