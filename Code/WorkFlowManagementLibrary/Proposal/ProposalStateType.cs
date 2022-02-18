using System.ComponentModel.DataAnnotations;

namespace WorkFlowManagementLibrary
{
    public enum ProposalStatus
    {
        [Display(Name = "Draft")]
        Draft = 0,
        [Display(Name = "Approved")]
        Approved = 1,
        [Display(Name = "Declined")]
        Declined = 2,
        [Display(Name = "Submitted")]
        Submitted = 3,
        [Display(Name = "Pre-Approved")]
        PreApproved = 4
    }
}
