

namespace AffiliateProposalStatePatternLibrary
{
    // The base State class declares methods that all Concrete State should
    // implement and also provides a backreference to the Context object,
    // associated with the State. This backreference can be used by States to
    // transition the Context to another State.
    public abstract class ProposalState
    {
        protected ProposalContext _context;
        private ProposalStatus _proposalStatus;
        public ProposalStatus ProposalStatus { get => _proposalStatus; set => _proposalStatus = value; }

        public void SetContext(ProposalContext context)
        {
            this._context = context;
        }

        public abstract void Submit();

        public abstract void Approve();

        public abstract void Decline();
    }
}
