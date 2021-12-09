namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderVendorQuoteRejected : ReactiveWOState
    {
        public ReactiveWorkOrderVendorQuoteRejected()
        {
            this.Status = WorkOrderStatus.VendorQuoteRejected;
        }

        public override void AffiliateEntersQuote()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderVendorQuoteSubmitted());
        }

    }
}
