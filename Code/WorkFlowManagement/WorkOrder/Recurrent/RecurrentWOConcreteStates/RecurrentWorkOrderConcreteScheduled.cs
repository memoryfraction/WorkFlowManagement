namespace WorkFlowManagement.WorkOrder.Recurrent.RecurrentWOConcreteStates
{
    public class RecurrentWorkOrderConcreteScheduled : RecurrentWOState
    {
        public RecurrentWorkOrderConcreteScheduled()
        {
            this.Status = WorkOrderStatus.Scheduled;
        }

        public override void CheckIn()
        {
            this._context.ChangeStateTo(new RecurrentWorkOrderConcreteOnSite());
        }

        public override void Undo()
        {
            this._context.ChangeStateTo(new RecurrentWorkOrderConcretePendingSchedule());
        }
    }
}
