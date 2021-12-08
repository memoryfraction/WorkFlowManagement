using System;

namespace WorkFlowManagement.WorkOrder.Reactive
{
    public class ReactiveWOContext
    {
        // A reference to the current state of the Context.
        private ReactiveWOState _state = null;
        public ReactiveWOState State { get => _state; set => _state = value; }


        public ReactiveWOContext(ReactiveWOState state)
        {
            this.ChangeStateTo(state);
        }

        // The Context allows changing the State object at runtime.
        public void ChangeStateTo(ReactiveWOState state)
        {
            var curStateName = _state == null ? "NA" : _state?.GetType().Name;
            Console.WriteLine($"Context: Changing State: from { curStateName } to {state.GetType().Name}.");
            this.State = state;
            this.State.SetContext(this);
        }
    }
}
