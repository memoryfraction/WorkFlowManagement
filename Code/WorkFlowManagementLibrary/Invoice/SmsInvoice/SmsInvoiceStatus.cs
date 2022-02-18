using System.ComponentModel.DataAnnotations;

namespace WorkFlowManagementLibrary.Invoice.SmsInvoice
{
    public enum SmsInvoiceStatus
    {
        [Display(Name = "Draft")]
        Draft = 0,
        [Display(Name = "SMS Audit Approved")]
        SmsAuditApproved = 1,
        [Display(Name = "SMS Audit Declined")]
        SmsAuditDeclined = 2,
        [Display(Name = "Submitted for SMS Audit")]
        SubmittedForSmsAudit = 3,
        [Display(Name = "Client Approved")]
        ClientApproved = 4,
        [Display(Name = "Client Declined")]
        ClientDeclined = 5,
        [Display(Name = "Client Disputed")]
        ClientDisputed = 6
    }
}
