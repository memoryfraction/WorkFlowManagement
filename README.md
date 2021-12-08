# Context
Business logic in Sms Assist LLC is around work order, proposal, and invoice. there are lot of if...else becuase of the dozens of status for work orders, which is difficult to maintain.


# StatesPattern
Status Pattern For ReactiveWorkOrder, SMSInvoice, AffiliateInvoice, and Proposal in Sms Assist LLC


Pros and Cons for the state pattern
## Pros
* The single responsibility principle places code related to a particular state in a seperate class.
* Open-Close principle. No need to change the existing status and context to add a new state.
* Clean the redundent "if ... else..."
* reduce the maintenance cost for the life cycle
* Lowering the learning curve for new Software Developer

## Cons
* If there aren't not enough status, the state pattern is not necessary



## Design

![UMLDesign](https://github.com/memoryfraction/StatusPattern/blob/main/Documents/Figs/UMLDesign.png)
![ProposalWorkFlow](https://github.com/memoryfraction/StatusPattern/blob/main/Documents/Figs/Proposal%20workflow.png)


# Sample Code

```C#
using StatePatternLibrary;
using StatePatternLibrary.ConcreteStates;

var proposalContext = new ProposalContext(new ProposalConcreteStateDraft());
proposalContext.State.Submit();
Console.WriteLine($"The Current Status:{proposalContext.State.ProposalStatus}");
proposalContext.State.Decline();
Console.WriteLine($"The Current Status:{proposalContext.State.ProposalStatus}");
proposalContext.State.Approve();
Console.WriteLine($"The Current Status:{proposalContext.State.ProposalStatus}");
Console.WriteLine("Done");
```
![Output](https://github.com/memoryfraction/StatusPattern/blob/main/Documents/Figs/Output.png)

# UnitTests
![UnitTestForSmsInvoice](https://github.com/memoryfraction/StatusPattern/blob/main/Documents/Figs/UnittestForSmsInvoices.png)

