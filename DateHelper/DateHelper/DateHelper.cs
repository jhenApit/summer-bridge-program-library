﻿using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DateHelperLibrary
{
    public class DateHelper
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }

        public DayOfWeek GetDayOfWeek(DateTime date)
        {
            return date.DayOfWeek;
        }

        public int CalculateAge(DateTime birthdate)
        {
            int age = DateTime.Now.Year - birthdate.Year;

            if (DateTime.Now.Month < birthdate.Month ||
                (DateTime.Now.Month == birthdate.Month && DateTime.Now.Day < birthdate.Day))
            {
                age--;
            }

            return age;
        }

        public string FormatDateTime(DateTime dateTime, string format)
        {
            return dateTime.ToString(format);
        }

        /// <summary>
        /// Calculates the time difference between the start and end date and time.
        /// </summary>
        /// <param name="startDateTime">The start date and time.</param>
        /// <param name="endDateTime">The end date and time.</param>
        /// <returns>The time span representing the difference between the start and end date and time.</returns>
         public TimeSpan GetTimeDifference(DateTime startDateTime, DateTime endDateTime)
        {
            return endDateTime - startDateTime;
        }

        public DateTime AddDays(DateTime date, int days)
        {
            return date.AddDays(days);
        }
    }
}