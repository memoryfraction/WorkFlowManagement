namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderPendingVendorQuote : ReactiveWOState
    {
        public ReactiveWorkOrderPendingVendorQuote()
        {
            this.Status = WorkOrderStatus.PendingVendorQuote;
        }

        public override void AffiliateEntersQuote()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderVendorQuoteSubmitted());
        }


    }
}
