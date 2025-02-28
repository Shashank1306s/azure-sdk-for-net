// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The properties of the schedule. </summary>
    public partial class ScheduleProperties
    {
        /// <summary> Initializes a new instance of ScheduleProperties. </summary>
        /// <param name="frequency"> Frequency of the schedule. </param>
        /// <param name="startOn"> The start date and time of the scheduled action (UTC). </param>
        /// <param name="endOn"> The end date and time of the scheduled action (UTC). </param>
        public ScheduleProperties(ScheduleFrequency frequency, DateTimeOffset startOn, DateTimeOffset endOn)
        {
            Frequency = frequency;
            DaysOfWeek = new ChangeTrackingList<ScheduledActionDaysOfWeek>();
            WeeksOfMonth = new ChangeTrackingList<ScheduledActionWeeksOfMonth>();
            StartOn = startOn;
            EndOn = endOn;
        }

        /// <summary> Initializes a new instance of ScheduleProperties. </summary>
        /// <param name="frequency"> Frequency of the schedule. </param>
        /// <param name="hourOfDay"> UTC time at which cost analysis data will be emailed. </param>
        /// <param name="daysOfWeek"> Day names in english on which cost analysis data will be emailed. This property is applicable when frequency is Weekly or Monthly. </param>
        /// <param name="weeksOfMonth"> Weeks in which cost analysis data will be emailed. This property is applicable when frequency is Monthly and used in combination with daysOfWeek. </param>
        /// <param name="dayOfMonth"> UTC day on which cost analysis data will be emailed. Must be between 1 and 31. This property is applicable when frequency is Monthly and overrides weeksOfMonth or daysOfWeek. </param>
        /// <param name="startOn"> The start date and time of the scheduled action (UTC). </param>
        /// <param name="endOn"> The end date and time of the scheduled action (UTC). </param>
        internal ScheduleProperties(ScheduleFrequency frequency, int? hourOfDay, IList<ScheduledActionDaysOfWeek> daysOfWeek, IList<ScheduledActionWeeksOfMonth> weeksOfMonth, int? dayOfMonth, DateTimeOffset startOn, DateTimeOffset endOn)
        {
            Frequency = frequency;
            HourOfDay = hourOfDay;
            DaysOfWeek = daysOfWeek;
            WeeksOfMonth = weeksOfMonth;
            DayOfMonth = dayOfMonth;
            StartOn = startOn;
            EndOn = endOn;
        }

        /// <summary> Frequency of the schedule. </summary>
        public ScheduleFrequency Frequency { get; set; }
        /// <summary> UTC time at which cost analysis data will be emailed. </summary>
        public int? HourOfDay { get; set; }
        /// <summary> Day names in english on which cost analysis data will be emailed. This property is applicable when frequency is Weekly or Monthly. </summary>
        public IList<ScheduledActionDaysOfWeek> DaysOfWeek { get; }
        /// <summary> Weeks in which cost analysis data will be emailed. This property is applicable when frequency is Monthly and used in combination with daysOfWeek. </summary>
        public IList<ScheduledActionWeeksOfMonth> WeeksOfMonth { get; }
        /// <summary> UTC day on which cost analysis data will be emailed. Must be between 1 and 31. This property is applicable when frequency is Monthly and overrides weeksOfMonth or daysOfWeek. </summary>
        public int? DayOfMonth { get; set; }
        /// <summary> The start date and time of the scheduled action (UTC). </summary>
        public DateTimeOffset StartOn { get; set; }
        /// <summary> The end date and time of the scheduled action (UTC). </summary>
        public DateTimeOffset EndOn { get; set; }
    }
}
