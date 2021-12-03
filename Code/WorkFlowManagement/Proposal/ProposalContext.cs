using System;

namespace StatePatternLibrary
{
    public class ProposalContext
    {
        // A reference to the current state of the Context.
        private ProposalState _state = null;
        public ProposalState State { get => _state; set => _state = value; }


        public ProposalContext(ProposalState state)
        {
            this.ChangeStateTo(state);
        }

        // The Context allows changing the State object at runtime.
        public void ChangeStateTo(ProposalState state)
        {
            var curStateName = _state == null ? "NA" : _state?.GetType().Name;
            Console.WriteLine($"Context: Changing State: from { curStateName } to {state.GetType().Name}.");
            this.State = state;
            this.State.SetContext(this);
        }
    }

   

}
