﻿using System;
using System.Globalization;
using System.Windows.Forms;

namespace Barroc_IT
{
    static class DateHandler
    {
        public static string GetDate(DateTimePicker dtp)
        {
            string date = dtp.Value.Year.ToString();
            int a = dtp.Value.Month;

            if (a < 10)
            {
                date += "0" + dtp.Value.Month.ToString();
            }
            else
            {
                date += dtp.Value.Month.ToString();
            }
            a = dtp.Value.Day;

            if (a < 10)
            {
                date += "0" + dtp.Value.Day.ToString();
            }
            else
            {
                date += dtp.Value.Day.ToString();
            }

            return date;
        }

        public static string GetDateWithMinus(DateTimePicker dtp)
        {
            string date = dtp.Value.Year.ToString() + "-";
            int a = dtp.Value.Month;

            if (a < 10)
            {
                date += "0" + dtp.Value.Month.ToString() + "-";
            }
            else
            {
                date += dtp.Value.Month.ToString() + "-";
            }
            a = dtp.Value.Day;

            if (a < 10)
            {
                date += "0" + dtp.Value.Day.ToString();
            }
            else
            {
                date += dtp.Value.Day.ToString();
            }

            return date;
        }

        public static DateTime? toDate(this string dateTimeStr, string[] dateFmt)
        {
            const DateTimeStyles style = DateTimeStyles.AllowWhiteSpaces;
            DateTime? result = null;
            DateTime dt;
            if (DateTime.TryParseExact(dateTimeStr, dateFmt,
                CultureInfo.InvariantCulture, style, out dt)) result = dt;
            return result;
        }

        public static DateTime? toDate(this string dateTimeStr, string dateFmt)
        {
            // call overloaded function with string array param     
            return toDate(dateTimeStr, new string[] { dateFmt });
        }
    }
}
