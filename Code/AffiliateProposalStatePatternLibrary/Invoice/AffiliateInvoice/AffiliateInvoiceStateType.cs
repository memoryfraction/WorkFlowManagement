﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AffiliateProposalStatePatternLibrary
{
    public enum AffiliateInvoiceStatus
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
