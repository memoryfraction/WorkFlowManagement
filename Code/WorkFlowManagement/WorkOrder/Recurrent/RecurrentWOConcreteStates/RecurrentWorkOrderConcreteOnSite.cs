
namespace WorkFlowManagement.WorkOrder.Recurrent.RecurrentWOConcreteStates
{
    public class RecurrentWorkOrderConcreteOnSite : RecurrentWOState
    {
        public RecurrentWorkOrderConcreteOnSite()
        {
            this.Status = WorkOrderStatus.OnSite;
        }

        public virtual void CheckIn()
        {
            this._context.ChangeStateTo(new RecurrentWorkOrderConcreteOnSite());
        }
    }
}
