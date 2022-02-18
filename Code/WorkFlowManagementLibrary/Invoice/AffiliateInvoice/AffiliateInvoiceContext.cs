using WorkFlowManagementLibrary;
using System;

namespace WorkFlowManagementLibrary
{
    public class AffiliateInvoiceContext
    {
        // A reference to the current state of the Context.
        private AffiliateInvoiceState _state = null;
        public AffiliateInvoiceState State { get => _state; set => _state = value; }


        public AffiliateInvoiceContext(AffiliateInvoiceState state)
        {
            this.ChangeStateTo(state);
        }

        // The Context allows changing the State object at runtime.
        public void ChangeStateTo(AffiliateInvoiceState state)
        {
            var curStateName = _state == null ? "NA" : _state?.GetType().Name;
            Console.WriteLine($"Context: Changing State: from { curStateName } to {state.GetType().Name}.");
            this.State = state;
            this.State.SetContext(this);
        }
    }

   

}
