namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderCompletedAndInvoiced : ReactiveWOState
    {
        public ReactiveWorkOrderCompletedAndInvoiced()
        {
            this.Status = WorkOrderStatus.CompletedandInvoiced;
        }

        public override void Bill()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderBilled());
        }

    }
}
