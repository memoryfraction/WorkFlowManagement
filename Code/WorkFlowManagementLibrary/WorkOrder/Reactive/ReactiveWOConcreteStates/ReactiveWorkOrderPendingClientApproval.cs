namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderPendingClientApproval : ReactiveWOState
    {
        public ReactiveWorkOrderPendingClientApproval()
        {
            this.Status = WorkOrderStatus.PendingApproval;
        }

        public override void ApproveClientQuote()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderClientQuoteApproved());
        }

        public override void RejectClientQuote()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderClientQuoteRejected());
        }



    }
}
