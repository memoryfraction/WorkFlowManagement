using WorkFlowManagementLibrary.ConcreteStates;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowManagementLibrary.ConcreteStates
{
    public class ProposalConcreteStatePreApprove : ProposalState
    {
        public ProposalConcreteStatePreApprove()
        {
            this.ProposalStatus = ProposalStatus.PreApproved;
        }

        public override void Approve()
        {
            this._context.ChangeStateTo(new ProposalConcreteStateApproved());
        }

        public override void Decline()
        {
            this._context.ChangeStateTo(new ProposalConcreteStateDeclined());
        }

        public override void Submit()
        {
            throw new InvalidOperationException("PreApproved Proposal can't be submitted again.");
        }

        public override void PreApprove()
        {
            throw new InvalidOperationException("PreApproved Proposal can't be PreApproved again.");
        }
    }
}
