/*
Module Name:  IntToolsTestSuite.cs
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

namespace Test.SManager.Core
{
    using global::SManager.Core;
    using NUnit.Framework;

    /// <summary>
    /// Defines the <see cref="IntToolsTestSuite" />.
    /// </summary>
    [TestFixture()]
    public class IntToolsTestSuite
    {
        /// <summary>
        /// Defines the _resultOfClamp.
        /// </summary>
        private int _resultOfClamp;

        /// <summary>
        /// The Clamp_ReturnClampedValue.
        /// </summary>
        /// <param name="value">The value <see cref="int" />.</param>
        /// <param name="min">The min <see cref="int" />.</param>
        /// <param name="max">The max <see cref="int" />.</param>
        [TestCase(-12, 1, 5)]
        [TestCase(3, 1, 5)]
        [TestCase(12, 1, 5)]
        public void Clamp_ReturnClampedValue(int value, int min, int max)
        {
            _resultOfClamp = IntTools.Clamp(value, min, max);
            if ((_resultOfClamp >= min && _resultOfClamp <= max) || Equals(value, _resultOfClamp))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// The Clamp_ReturnException.
        /// </summary>
        [Test()]
        public void Clamp_ReturnException()
        {
            Assert.Throws(Is.TypeOf<System.ArithmeticException>(), () => IntTools.Clamp(3, 5, 1));
        }

        /// <summary>
        /// The SetUp.
        /// </summary>
        [SetUp()]
        public void SetUp()
        {
            _resultOfClamp = new int();
        }
    }
}