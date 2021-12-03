using System;

namespace WorkFlowManagement.WorkOrder
{
    public class RecurrentWOContext
    {
        // A reference to the current state of the Context.
        private RecurrentWOState _state = null;
        public RecurrentWOState State { get => _state; set => _state = value; }


        public RecurrentWOContext(RecurrentWOState state)
        {
            this.ChangeStateTo(state);
        }

        // The Context allows changing the State object at runtime.
        public void ChangeStateTo(RecurrentWOState state)
        {
            var curStateName = _state == null ? "NA" : _state?.GetType().Name;
            Console.WriteLine($"Context: Changing State: from { curStateName } to {state.GetType().Name}.");
            this.State = state;
            this.State.SetContext(this);
        }
    }

   

}
