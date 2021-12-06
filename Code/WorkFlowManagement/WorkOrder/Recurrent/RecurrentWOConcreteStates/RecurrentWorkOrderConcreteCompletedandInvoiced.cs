
namespace WorkFlowManagement.WorkOrder.Recurrent.RecurrentWOConcreteStates
{
    public class RecurrentWorkOrderConcreteCompletedandInvoiced : RecurrentWOState
    {
        public RecurrentWorkOrderConcreteCompletedandInvoiced()
        {
            this.Status = WorkOrderStatus.CompletedandInvoiced;
        }

        public virtual void PaytoAffiliate()
        {
            this._context.ChangeStateTo(new RecurrentWorkOrderConcreteCompletedandInvoiced());
        }
    }
}
