# StatesPattern
Status Pattern For WorkOrder, Invoice, and Proposal SmsAssist


Pros and Cons for the state pattern
## Pros
* The single responsibility principle places code related to a particular state in a seperate class.
* Open-Close principle. No need to change the existing status and context to add a new state.
* Clean the redundent "if ... else..."

## Cons
* If there aren't not enough status, the state pattern is not necessary



## Design

![UMLDesign](https://github.com/memoryfraction/StatusPattern/blob/main/Documents/Figs/UMLDesign.png)
![UMLDesign](https://github.com/memoryfraction/StatusPattern/bl…n/Documents/Figs/Proposal%20workflow.png)


# Sample Code

```C#
using AffiliateProposalStatePatternLibrary;
using AffiliateProposalStatePatternLibrary.ConcreteStates;

var context = new AffiliateProposalContext(new ConcreteStateDraft());
context.State.Submit();

context.State.Decline();

context.State.Approve();

Console.WriteLine("Done");
```


![Output](https://github.com/memoryfraction/StatusPattern/blob/main/Documents/Figs/Output.png)

