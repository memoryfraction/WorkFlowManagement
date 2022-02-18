namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderVendorPaid : ReactiveWOState
    {
        public ReactiveWorkOrderVendorPaid()
        {
            this.Status = WorkOrderStatus.VendorPaid;
        }



    }
}
