using System;

namespace WorkFlowManagementLibrary.ConcreteStates
{
    public class AffiliateInvoiceConcreteStateDeclined : AffiliateInvoiceState
    {

        public AffiliateInvoiceConcreteStateDeclined()
        {
            this.Status = AffiliateInvoiceStatus.Declined;
        }

        public override void Approve()
        {
            this._context.ChangeStateTo(new AffiliateInvoiceConcreteStateApproved());
        }

        public override void Decline()
        {
            throw new InvalidOperationException("Declined Proposal can't be declined.");
        }

        public override void Submit()
        {
            throw new InvalidOperationException("Submitted Proposal can't be submitted.");
        }
    }
}
