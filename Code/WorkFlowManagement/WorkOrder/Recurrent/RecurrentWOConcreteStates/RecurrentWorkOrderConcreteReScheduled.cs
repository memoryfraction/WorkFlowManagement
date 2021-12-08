namespace WorkFlowManagement.WorkOrder.Recurrent.RecurrentWOConcreteStates
{
    public class RecurrentWorkOrderConcreteReScheduled : RecurrentWOState
    {
        public RecurrentWorkOrderConcreteReScheduled()
        {
            this.Status = WorkOrderStatus.Rescheduled;
        }


        public override void CheckIn()
        {
            this._context.ChangeStateTo(new RecurrentWorkOrderConcreteOnSite());
        }
        public override void ReSchedule()
        {
            this._context.ChangeStateTo(new RecurrentWorkOrderConcreteScheduled());
        }
    }
}
