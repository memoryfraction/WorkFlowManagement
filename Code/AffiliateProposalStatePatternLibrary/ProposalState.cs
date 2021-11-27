using System;
using System.Collections.Generic;
using System.Text;

namespace AffiliateProposalStatePatternLibrary
{
    // The base State class declares methods that all Concrete State should
    // implement and also provides a backreference to the Context object,
    // associated with the State. This backreference can be used by States to
    // transition the Context to another State.
    public abstract class ProposalState
    {
        protected AffiliateProposalContext _context;
        private ProposalStateType _proposalState;
        public ProposalStateType ProposalStateType { get => _proposalState; set => _proposalState = value; }

        public void SetContext(AffiliateProposalContext context)
        {
            this._context = context;
        }

        public abstract void Submit();

        public abstract void Approve();

        public abstract void Decline();
    }
}
