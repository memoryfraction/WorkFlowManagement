namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderVendorQuoteSubmitted : ReactiveWOState
    {
        public ReactiveWorkOrderVendorQuoteSubmitted()
        {
            this.Status = WorkOrderStatus.VendorQuoteSubmitted;
        }


        public override void ApprovePendingClientQuote()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderPendingClientApproval());
        }


    }
}
