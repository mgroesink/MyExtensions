using System;
using System.Collections.Generic;
using System.Linq;

namespace MyExtensions
{

    /// <summary>
    /// Class with several extension methods
    /// Written by Marcel Roesink
    /// </summary>
    public static class MyExtensionMethods
    {

        #region Numeric Extension

        /// <summary>
        /// Rounds to nearest number.
        /// </summary>
        /// <param name="number">The number to round.</param>
        /// <param name="roundto">The number to roundto.</param>
        /// <returns></returns>
        public static decimal RoundTo(this decimal number, int roundto)
        {
            return Math.Round(number * (100 / roundto)) / (100 / roundto);
        }
        #endregion

        #region Collection Extensions
        /// <summary>
        /// Calculates the standard deviation of a specified array of integers.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns></returns>
        public static double Stdev(this int[] array)
        {
            double avg = array.Average();
            double dev = 0;
            foreach (var item in array)
            {
                var diff = item - avg;
                dev += (diff * diff);
            }
            return Math.Sqrt(dev / array.Length);
        }

        public static double Stdev(this List<int> list)
        {
            double avg = list.Average();
            double dev = 0;
            foreach (var item in list)
            {
                var diff = item - avg;
                dev += (diff * diff);
            }
            return Math.Sqrt(dev / list.Count);
        }

        /// <summary>
        /// Calculates the standard deviation of a specified array of doubles.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns></returns>
        public static double Stdev(this double[] array)
        {
            double avg = array.Average();
            double dev = 0;
            foreach (var item in array)
            {
                var diff = item - avg;
                dev += (diff * diff);
            }
            return Math.Sqrt(dev / array.Length);
        }

        /// <summary>
        /// Calculates the standard deviation of a specified array of decimals.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns></returns>
        public static decimal Stdev(this decimal[] array)
        {
            decimal avg = array.Average();
            decimal dev = 0;
            foreach (var item in array)
            {
                var diff = item - avg;
                dev += (diff * diff);
            }
            return (decimal)Math.Sqrt((double)dev / array.Length);
        }

        #endregion

        /// <summary>
        /// Calculates the age for a given date.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public static int Age(this DateTime date)
        {
            int age = DateTime.Now.Year - date.Year;
            if (date.Month > DateTime.Now.Month) age--;
            else if (date.Month == DateTime.Now.Month && date.Day > DateTime.Now.Day) age--;
            return age;
        }
    }
}
