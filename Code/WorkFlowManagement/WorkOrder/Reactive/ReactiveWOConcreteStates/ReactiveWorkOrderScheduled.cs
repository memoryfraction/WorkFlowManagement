namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderScheduled : ReactiveWOState
    {
        public ReactiveWorkOrderScheduled()
        {
            this.Status = WorkOrderStatus.Scheduled;
        }

        public override void CheckIn()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderOnsite());
        }
    }
}
