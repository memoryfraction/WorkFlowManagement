namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderReturnTripNeeded : ReactiveWOState
    {
        public ReactiveWorkOrderReturnTripNeeded()
        {
            this.Status = WorkOrderStatus.ReturnTripNeeded;
        }

        public override void Schedule()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderScheduled());
        }

    }
}
