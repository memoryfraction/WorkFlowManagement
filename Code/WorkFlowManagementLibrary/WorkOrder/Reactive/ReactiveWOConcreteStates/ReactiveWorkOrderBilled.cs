namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderBilled : ReactiveWOState
    {
        public ReactiveWorkOrderBilled()
        {
            this.Status = WorkOrderStatus.Billed;
        }

        public override void PayVendor()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderVendorPaid());
        }

    }
}
