﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowManagement.WorkOrder
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    internal sealed class WorkOrderTypeAttribute : Attribute
    {
        public WorkOrderType Type { get; set; }
    }
}
