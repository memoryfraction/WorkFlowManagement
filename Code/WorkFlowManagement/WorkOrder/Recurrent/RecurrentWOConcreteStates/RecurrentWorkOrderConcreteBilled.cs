
namespace WorkFlowManagement.WorkOrder.Recurrent.RecurrentWOConcreteStates
{
    public class RecurrentWorkOrderConcreteBilled : RecurrentWOState
    {
        public RecurrentWorkOrderConcreteBilled()
        {
            this.Status = WorkOrderStatus.Billed;
        }

        public override void PaytoAffiliate()
        {
            this._context.ChangeStateTo(new RecurrentWorkOrderConcreteCompletedandInvoiced());
        }

        public override void Undo()
        {
            this._context.ChangeStateTo(new RecurrentWorkOrderConcreteOnSite());
        }

    }
}
