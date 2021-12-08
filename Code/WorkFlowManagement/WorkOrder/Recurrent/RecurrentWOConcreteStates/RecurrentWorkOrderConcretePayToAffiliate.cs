
namespace WorkFlowManagement.WorkOrder.Recurrent.RecurrentWOConcreteStates
{
    public class RecurrentWorkOrderConcretePayToAffiliate : RecurrentWOState
    {
        public RecurrentWorkOrderConcretePayToAffiliate()
        {
            this.Status = WorkOrderStatus.PaytoAffiliate;
        }

    }
}
