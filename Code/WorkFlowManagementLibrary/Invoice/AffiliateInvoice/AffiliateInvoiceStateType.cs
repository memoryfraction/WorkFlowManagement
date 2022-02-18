using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WorkFlowManagementLibrary
{
    public enum AffiliateInvoiceStatus
    {
        [Display(Name = "Draft")]
        Draft = 0,
        //not used
        [Display(Name = "Approved")]
        Approved = 1,
        [Display(Name = "Declined")]
        Declined = 2,
        [Display(Name = "Submitted")]
        Submitted = 3
    }
}
