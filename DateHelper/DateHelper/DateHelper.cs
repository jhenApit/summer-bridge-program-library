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

        public DateTime AddDays(DateTime date, int days)
        {
            return date.AddDays(days);
        }
    }
}