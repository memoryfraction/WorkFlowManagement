﻿using System;

namespace AffiliateProposalStatePatternLibrary.ConcreteStates
{
    public class ProposalConcreteStateDeclined : ProposalState
    {

        public ProposalConcreteStateDeclined()
        {
            this.ProposalStatus = ProposalStatus.Declined;
        }

        public override void Approve()
        {
            this._context.ChangeStateTo(new ProposalConcreteStateApproved());
        }

        public override void Decline()
        {
            throw new InvalidOperationException("Declined Proposal can't been declined.");
        }

        public override void Submit()
        {
            throw new InvalidOperationException("Submitted Proposal can't been submitted.");
        }
    }
}
