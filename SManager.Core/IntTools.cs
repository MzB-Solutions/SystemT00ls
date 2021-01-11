/*
Module Name:  IntTools.cs
Project:             <Sample Name>
Author:	           HOME\smzb
Copyright (c) 2000-2021 MzB Solutions

<Description of the file>

This source is subject to the Unlicense.
See https://github.com/MzB-Solutions/SManager/raw/master/LICENSE.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
*/

namespace SManager.Core
{
    using System;

    /// <summary>
    /// A few simple tools for int handling (ensure its non-null etc).
    /// </summary>
    public static class IntTools
    {
        /// <summary>
        /// Clamp an int down to a min and max value.
        /// </summary>
        /// <typeparam name="T">The type of value handed in.</typeparam>
        /// <param name="value">The actual value of our (hopefullly) int.</param>
        /// <param name="min">The minimum value for the clamp operation.</param>
        /// <param name="max">The maximum value for the clamp operation.</param>
        /// <returns>The <see cref="T" />.</returns>
        public static T Clamp<T>(T value, T min, T max) where T : notnull, IComparable<T>
        {
            if (min.CompareTo(max) > 0)
            {
                throw new ArithmeticException($"[min] Value ({min}) cannot be greater than [max] Value ({max})");
            }
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
    }
}