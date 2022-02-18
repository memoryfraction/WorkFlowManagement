namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderWorkCompletePendingVendorInvoice : ReactiveWOState
    {
        public ReactiveWorkOrderWorkCompletePendingVendorInvoice()
        {
            this.Status = WorkOrderStatus.WorkCompletePendingVendorInvoice;
        }

        public override void AffiliateCreatesInvoice()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderVendorInvoiceReceived());
        }

    }
}
