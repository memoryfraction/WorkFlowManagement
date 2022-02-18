
namespace WorkFlowManagement.WorkOrder.Recurrent.RecurrentWOConcreteStates
{
    public class RecurrentWorkOrderConcreteOnSite : RecurrentWOState
    {
        public RecurrentWorkOrderConcreteOnSite()
        {
            this.Status = WorkOrderStatus.OnSite;
        }

        public override void CheckOut()
        {
            this._context.ChangeStateTo(new RecurrentWorkOrderConcreteCompleted());
        }

      
    }
}
