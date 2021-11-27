// See https://aka.ms/new-console-template for more information

using AffiliateProposalStatePatternLibrary;
using AffiliateProposalStatePatternLibrary.ConcreteStates;

var context = new AffiliateProposalContext(new ConcreteStateDraft());
context.State.Submit();

context.State.Decline();

context.State.Approve();

Console.WriteLine("Done");
