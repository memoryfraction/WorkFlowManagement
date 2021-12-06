
namespace WorkFlowManagement.WorkOrder.Recurrent.RecurrentWOConcreteStates
{
    public class RecurrentWorkOrderConcreteBilled : RecurrentWOState
    {
        public RecurrentWorkOrderConcreteBilled()
        {
            this.Status = WorkOrderStatus.Billed;
        }

        public virtual void PaytoAffiliate()
        {
            this._context.ChangeStateTo(new RecurrentWorkOrderConcreteCompletedandInvoiced());
        }
    }
}
