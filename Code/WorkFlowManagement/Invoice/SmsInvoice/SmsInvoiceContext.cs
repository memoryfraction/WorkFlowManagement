using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternLibrary.Invoice.SmsInvoice
{
    public class SmsInvoiceContext
    {
        private SmsInvoiceState _state = null;
        public SmsInvoiceState State { get => _state; set => _state = value; }


        public SmsInvoiceContext(SmsInvoiceState state)
        {
            this.ChangeStateTo(state);
        }

        // The Context allows changing the State object at runtime.
        public void ChangeStateTo(SmsInvoiceState state)
        {
            var curStateName = _state == null ? "NA" : _state?.GetType().Name;
            Console.WriteLine($"Context: Changing State: from { curStateName } to {state.GetType().Name}.");
            this.State = state;
            this.State.SetContext(this);
        }
    }
}
