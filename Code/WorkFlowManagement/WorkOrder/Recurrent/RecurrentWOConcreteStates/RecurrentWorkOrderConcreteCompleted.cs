
namespace WorkFlowManagement.WorkOrder.Recurrent.RecurrentWOConcreteStates
{
    public class RecurrentWorkOrderConcreteCompleted : RecurrentWOState
    {
        public RecurrentWorkOrderConcreteCompleted()
        {
            this.Status = WorkOrderStatus.Completed;
        }

        public virtual void BatchInvoice()
        {
            this._context.ChangeStateTo(new RecurrentWorkOrderConcreteBilled());
        }
    }
}
