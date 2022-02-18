using System;
using System.ComponentModel.DataAnnotations;

namespace WorkFlowManagement.WorkOrder
{
    /// <summary>
    /// 此枚举包含了Recurrent/Reactive WO的所有状态.
    /// </summary>
    public enum WorkOrderStatus
    {
        /// <summary>
        /// 未预约，只创建了WO.
        /// Recurrent
        /// </summary>
        //[Obsolete("This status is changed to Pending Schedule.")]
        //[WorkOrderType(Type = WorkOrderType.Recurrent)]
        //Unscheduled = 0,

        /// <summary>
        /// "N/A"
        /// </summary>
        [Display(Name = "N/A")]
        [WorkOrderType(Type = WorkOrderType.None)]
        Null = -1,

        /// <summary>
        /// Pending schedule
        /// </summary>
        [Display(Name = "Pending Schedule")]
        [WorkOrderType(Type = WorkOrderType.None)]
        PendingSchedule = 0,

        /// <summary>
        /// Reactive
        /// general client wo status is pending dispatch.
        /// </summary>
        [Display(Name = "Pending Dispatch")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        PendingDispatch = 1,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Pending Vendor Acceptance")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        PendingVendorAcceptance = 2,

        /// <summary>
        /// 已预约.
        /// Recurrent
        /// </summary>
        [WorkOrderType(Type = WorkOrderType.None)]
        Scheduled = 3,

        /// <summary>
        /// 工作进行中.
        /// Recurrent
        /// </summary>
        [Display(Name = "On Site")]
        [WorkOrderType(Type = WorkOrderType.None)]
        OnSite = 4,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Pending Vendor Quote")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        PendingVendorQuote = 5,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Vendor Quote Submitted")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        VendorQuoteSubmitted = 6,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Pending Client Approval")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        PendingApproval = 7,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Client Quote Rejected")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        QuoteRejected = 8,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Client Quote Approved")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        QuoteApproved = 9,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Return Trip Needed")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        ReturnTripNeeded = 10,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Work Complete Pending Vendor Invoice")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        WorkCompletePendingVendorInvoice = 11,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Vendor Invoice Received")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        VendorInvoiceReceived = 12,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Pending Invoice Approval")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        PendingInvoiceApproval = 13,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Vendor Invoice Rejected")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        VendorInvoiceRejected = 14,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Completed And Invoiced")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        CompletedandInvoiced = 15,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Vendor Paid")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        VendorPaid = 16,

        [WorkOrderType(Type = WorkOrderType.None)]
        Closed = 17,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Resolved Without Invoice")]
        [WorkOrderType(Type = WorkOrderType.None)]
        ResolvedWithoutInvoice = 18,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Resolved Without Dispatch")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        ResolvedWithoutDispatch = 19,

        [Display(Name = "Cancelled")]
        [WorkOrderType(Type = WorkOrderType.None)]
        Cancelled = 20,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Work Order Avoidance")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        WorkOrderAvoidance = 21,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Pending Self-Help Approval")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        PendingSelfHelpApproval = 22,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Self-Help Approved")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        SelfHelpApproved = 23,

        /// <summary>
        /// Recurrent
        /// </summary>
        [WorkOrderType(Type = WorkOrderType.None)]
        Deferred = 24,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Landlord Resolved")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        LandlordResolved = 25,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Vendor Quote Rejected")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        VendorQuoteRejected = 26,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Self-Help Rejected")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        SelfHelpRejected = 27,

        /// <summary>
        /// Reactive
        /// </summary>
        [Display(Name = "Billed - In Progress")]
        [WorkOrderType(Type = WorkOrderType.Reactive)]
        BilledInProgress = 28,

        /// <summary>
        /// 已付款. Recurrent
        /// </summary>
        [Display(Name = "Billed")]
        [WorkOrderType(Type = WorkOrderType.None)]
        Billed = 29,

        /// <summary>
        /// Within 3 hrs scheduled time.  Affilaite IVR i, No? SQL agent job change status to Missed.
        /// 只有Scheduled或者Rescheduled才能变更为Missed.
        /// Recurrent
        /// </summary>
        [WorkOrderType(Type = WorkOrderType.Recurrent)]
        Missed = 30,

        /// <summary>
        /// 重新预约.
        /// Recurrent
        /// </summary>
        [WorkOrderType(Type = WorkOrderType.Recurrent)]
        Rescheduled = 31,

        /// <summary>
        /// Recurrent
        /// </summary>
        [WorkOrderType(Type = WorkOrderType.Recurrent)]
        Completed = 32,

        [Display(Name = "Pay to Affiliate")]
        [WorkOrderType(Type = WorkOrderType.Recurrent)]
        PaytoAffiliate = 33,

        /// <summary>
        /// Did not check in till 3 day at noon after scheduled.
        /// 只有Missed才能变更为Expired.
        /// Recurrent
        /// </summary>
        [WorkOrderType(Type = WorkOrderType.Recurrent)]
        Expired = 34,

        /// <summary>
        /// No check out within 12 hours.
        /// 只有In Progress才能变更为Void.
        /// Recurrent
        /// </summary>
        [Display(Name = "Void")]
        [WorkOrderType(Type = WorkOrderType.Recurrent)]
        Void = 35,

        /// <summary>
        /// Recurrent
        /// </summary>
        [Display(Name = "Log Refusal")]
        [WorkOrderType(Type = WorkOrderType.Recurrent)]
        LogRefusal = 36,

        /// <summary>
        /// Recurrent
        /// </summary>
        [Display(Name = "Service Pool")]
        [WorkOrderType(Type = WorkOrderType.Recurrent)]
        ServicePool = 37,
    }
}
