namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderClientQuoteRejected : ReactiveWOState
    {
        public ReactiveWorkOrderClientQuoteRejected()
        {
            this.Status = WorkOrderStatus.QuoteRejected;
        }

        public override void RejectVendorQuote()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderVendorQuoteRejected());
        }

    }
}
