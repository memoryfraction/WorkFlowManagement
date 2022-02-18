namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderClientQuoteApproved : ReactiveWOState
    {
        public ReactiveWorkOrderClientQuoteApproved()
        {
            this.Status = WorkOrderStatus.QuoteApproved;
        }

        public override void ReturnTripNeeded()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderReturnTripNeeded());
        }

    }
}
