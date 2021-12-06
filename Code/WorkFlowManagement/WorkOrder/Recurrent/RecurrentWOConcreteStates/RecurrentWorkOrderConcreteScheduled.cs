namespace WorkFlowManagement.WorkOrder.Recurrent.RecurrentWOConcreteStates
{
    public class RecurrentWorkOrderConcreteScheduled : RecurrentWOState
    {
        public RecurrentWorkOrderConcreteScheduled()
        {
            this.Status = WorkOrderStatus.Scheduled;
        }

        public virtual void CheckIn()
        {
            this._context.ChangeStateTo(new RecurrentWorkOrderConcreteOnSite());
        }
    }
}
