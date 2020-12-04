using NUnit.Framework;
using static SManager.Core.IntTools;

namespace Tests.SManager.Core.IntTools
{
    [TestFixture]
    public class IntTools_ClampShould
    {
        #region Private Fields

        private int maxValue;
        private int minValue;

        #endregion Private Fields

        #region Private Properties

        private int ResultOfClamp { get; set; }

        #endregion Private Properties

        #region Public Methods

        [TestCase(-12)]
        [TestCase(3)]
        [TestCase(12)]
        public void Clamp_ReturnClampedValue(int value)
        {
            ResultOfClamp = Clamp(value, minValue, maxValue);
            if (ResultOfClamp >= minValue || ResultOfClamp <= maxValue || int.Equals(value, ResultOfClamp))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Clamp_ReturnException()
        {
            Assert.Throws(Is.TypeOf<System.ArgumentOutOfRangeException>(), () => Clamp(3, 5, 1));
        }

        [SetUp]
        public void SetUp()
        {
            ResultOfClamp = new int();
            minValue = 1;
            maxValue = 5;
        }

        #endregion Public Methods
    }
}