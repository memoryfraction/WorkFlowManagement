
namespace WorkFlowManagement.WorkOrder.Recurrent.RecurrentWOConcreteStates
{
    public class RecurrentWorkOrderConcreteBilled : RecurrentWOState
    {
        public RecurrentWorkOrderConcreteBilled()
        {
            this.Status = WorkOrderStatus.Billed;
        }

        public void PaytoAffiliate()
        {
            this._context.ChangeStateTo(new RecurrentWorkOrderConcretePayToAffiliate());
        }

     

    }
}
