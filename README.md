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


# Problem to resolve
StatusA + ActionB = StatusC(???)


# Steps to Use
```C#
Install-Package WorkFlowManagementLibrary -Version 1.0.0
```


# Sample Code

```C#
[TestMethod]
public void TestMethod_ClientQuoteApproved_Should_Work()
{
    // Arrange
    var context = new ReactiveWOContext(new ReactiveWorkOrderPendingDispatch());

    // Act
    context.State.Dispatch();
    context.State.Schedule();
    context.State.CheckIn();
    context.State.CheckOut(WorkOrderStatus.PendingVendorQuote);
    context.State.AffiliateEntersQuote();
    context.State.ApprovePendingClientQuote();
    context.State.RejectClientQuote();
    context.State.RejectVendorQuote();
    context.State.AffiliateEntersQuote();
    context.State.ApprovePendingClientQuote();
    context.State.ApproveClientQuote();

    // Assert
    Assert.AreEqual(WorkOrderStatus.QuoteApproved, context.State.Status);
}


[TestMethod]
public void TestMethodWholeWorkflowShouldWork()
{
    // Arrange
    var context = new RecurrentWOContext(new RecurrentWorkOrderConcretePendingSchedule());

    // Act
    context.State.Schedule();
    context.State.CheckIn();
    context.State.CheckOut();
    context.State.BatchInvoice();
    context.State.PaytoAffiliate();

    // Assert
    Assert.AreEqual(WorkOrderStatus.PaytoAffiliate, context.State.Status);
}
```

# UnitTests
![UnitTestForSmsInvoice](https://github.com/memoryfraction/StatusPattern/blob/main/Documents/Figs/UnittestForSmsInvoices.png)

