namespace WorkFlowManagement.WorkOrder.Reactive.ReactiveWOConcreteStates
{
    public class ReactiveWorkOrderVendorInvoiceRejected : ReactiveWOState
    {
        public ReactiveWorkOrderVendorInvoiceRejected()
        {
            this.Status = WorkOrderStatus.VendorInvoiceRejected;
        }

        public override void AffiliateCreatesInvoice()
        {
            this._context.ChangeStateTo(new ReactiveWorkOrderVendorInvoiceReceived());
        }

    }
}
