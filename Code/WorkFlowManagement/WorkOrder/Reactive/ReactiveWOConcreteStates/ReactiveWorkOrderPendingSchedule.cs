namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderPendingSchedule : ReactiveWOState
    {
        public ReactiveWorkOrderPendingSchedule()
        {
            this.Status = WorkOrderStatus.PendingSchedule;
        }

        public override void Schedule()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderScheduled());
        }
    }
}
