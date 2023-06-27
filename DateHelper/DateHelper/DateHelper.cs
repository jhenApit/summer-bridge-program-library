﻿using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DateHelperLibrary
{
    public class DateHelper
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
        /// <summary>
        /// this method returns true if year is leap year :))
        /// </summary>
        /// <param name="year"></param>
        /// <returns>bool</returns>
        public bool IsLeapYear (int year)
        {
            return DateTime.IsLeapYear(year);
        }
        public DayOfWeek GetDayOfWeek(DateTime date)
        {
            return date.DayOfWeek;
        }
        
        /// <summary>
        /// Calculates the age of someone
        /// </summary>
        /// <param name="birthDate">The date of birth.</param>
        /// <returns>An integer representing the age of someone.</returns>
        public int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;

            if (DateTime.Now.Month < birthDate.Month ||
                (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
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

        /// <summary>
        /// Adds any number of days to the given date.
        /// </summary>
        /// <param name="date">Date with year, month, and day.</param>
        /// <param name="days">Number of days to add in the given date.</param>
        /// <returns>Updated date</returns>
        public DateTime AddDays(DateTime date, int days)
        {
            return date.AddDays(days);
        }
    }
}