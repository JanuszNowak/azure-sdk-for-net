// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> Parameters for a schedule-based autoscale rule, consisting of an array of days + a time and capacity. </summary>
    public partial class AutoscaleSchedule
    {
        /// <summary> Initializes a new instance of AutoscaleSchedule. </summary>
        public AutoscaleSchedule()
        {
            Days = new ChangeTrackingList<DaysOfWeek>();
        }

        /// <summary> Initializes a new instance of AutoscaleSchedule. </summary>
        /// <param name="days"> Days of the week for a schedule-based autoscale rule. </param>
        /// <param name="timeAndCapacity"> Time and capacity for a schedule-based autoscale rule. </param>
        internal AutoscaleSchedule(IList<DaysOfWeek> days, AutoscaleTimeAndCapacity timeAndCapacity)
        {
            Days = days;
            TimeAndCapacity = timeAndCapacity;
        }

        /// <summary> Days of the week for a schedule-based autoscale rule. </summary>
        public IList<DaysOfWeek> Days { get; }
        /// <summary> Time and capacity for a schedule-based autoscale rule. </summary>
        public AutoscaleTimeAndCapacity TimeAndCapacity { get; set; }
    }
}
