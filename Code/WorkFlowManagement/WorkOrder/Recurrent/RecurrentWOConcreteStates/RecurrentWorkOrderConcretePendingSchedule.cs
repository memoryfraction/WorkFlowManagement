
namespace WorkFlowManagement.WorkOrder.Recurrent.RecurrentWOConcreteStates
{
    public class RecurrentWorkOrderConcretePendingSchedule : RecurrentWOState
    {
        public RecurrentWorkOrderConcretePendingSchedule()
        {
            this.Status = WorkOrderStatus.PendingSchedule;
        }

        public virtual void Schedule()
        {
            this._context.ChangeStateTo(new RecurrentWorkOrderConcreteScheduled());
        }

    }
}
