using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderPendingVendorAcceptance : ReactiveWOState
    {
        public ReactiveWorkOrderPendingVendorAcceptance()
        {
            this.Status = WorkOrderStatus.PendingVendorAcceptance;
        }

        public override void PendingSchedule()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderPendingSchedule());
        }

        public override void Schedule()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderScheduled());
        }
    }
}
