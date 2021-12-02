// See https://aka.ms/new-console-template for more information

using AffiliateProposalStatePatternLibrary;
using AffiliateProposalStatePatternLibrary.ConcreteStates;

var proposalContext = new ProposalContext(new ProposalConcreteStateDraft());

proposalContext.State.Submit();
Console.WriteLine($"The Current Status:{proposalContext.State.ProposalStatus}");
proposalContext.State.Decline();
Console.WriteLine($"The Current Status:{proposalContext.State.ProposalStatus}");
proposalContext.State.Approve();
Console.WriteLine($"The Current Status:{proposalContext.State.ProposalStatus}");
Console.WriteLine("Done");
