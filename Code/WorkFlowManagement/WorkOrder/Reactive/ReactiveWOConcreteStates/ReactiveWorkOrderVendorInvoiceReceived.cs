namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderVendorInvoiceReceived : ReactiveWOState
    {
        public ReactiveWorkOrderVendorInvoiceReceived()
        {
            this.Status = WorkOrderStatus.VendorInvoiceReceived;
        }

        public override void ApproveVendorInvoice()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderCompletedAndInvoiced());
        }

        public override void RejectVendorInvoice()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderVendorInvoiceRejected());
        }

    }
}
