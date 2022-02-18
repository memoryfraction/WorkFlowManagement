using System;

namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderOnsite : ReactiveWOState
    {
        public ReactiveWorkOrderOnsite()
        {
            this.Status = WorkOrderStatus.OnSite;
        }


        public override void CheckOut(WorkOrderStatus workOrderStatus)
        {
            if (workOrderStatus == WorkOrderStatus.ReturnTripNeeded)
            {
                this._context.ChangeStateTo(new ReactiveWorkOrderReturnTripNeeded());
            }
            else if (workOrderStatus == WorkOrderStatus.PendingVendorQuote)
            {
                this._context.ChangeStateTo(new ReactiveWorkOrderPendingVendorQuote());
            }
            else if (workOrderStatus == WorkOrderStatus.WorkCompletePendingVendorInvoice)
            {
                this._context.ChangeStateTo(new ReactiveWorkOrderWorkCompletePendingVendorInvoice());
            }
            else 
                throw new InvalidOperationException("Invalid Operation");
        }

       
    }
}
