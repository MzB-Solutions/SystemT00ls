using System;

namespace SManager.CoreLib
{
    /// <summary>
    /// A few simple tools for int handling (ensure its non-null etc)
    /// </summary>
    public static class IntTools
    {
        #region Public Methods

        /// <summary>
        /// Clamp an int down to a min and max value
        /// </summary>
        /// <remarks>Straight from https://stackoverflow.com/questions/3176602/how-to-force-a-number-to-be-in-a-range-in-c</remarks>
        /// <typeparam name="T">The type of value handed in</typeparam>
        /// <param name="value">The actual value of our (hopefullly) int</param>
        /// <param name="min">The minimum value for the clamp operation</param>
        /// <param name="max">The maximum value for the clamp operation</param>
        /// <returns>
        /// most likely an int-like type (preferably byte) that returns a clamped value, this should
        /// NEVER return any zero-like value, EVER!
        /// </returns>
        public static T Clamp<T>(T value, T min, T max) where T : notnull, IComparable<T>
        {
            if (value.CompareTo(min) < 0)
            {
                return min;
            }

            if (value.CompareTo(max) > 0)
            {
                return max;
            }

            return value;
        }

        #endregion Public Methods
    }
}