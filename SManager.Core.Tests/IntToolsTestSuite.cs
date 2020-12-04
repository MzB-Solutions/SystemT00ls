using NUnit.Framework;
using SManager.Core;

namespace Test.SManager.Core
{
    [TestFixture()]
    public class IntToolsTestSuite
    {
        #region Private Properties

        private int _resultOfClamp { get; set; }

        #endregion Private Properties

        #region Public Methods

        [TestCase(-12, 1, 5)]
        [TestCase(3, 1, 5)]
        [TestCase(12, 1, 5)]
        public void Clamp_ReturnClampedValue(int value, int min, int max)
        {
            _resultOfClamp = IntTools.Clamp(value, min, max);
            if ((_resultOfClamp >= min && _resultOfClamp <= max) || int.Equals(value, _resultOfClamp))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test()]
        public void Clamp_ReturnException()
        {
            Assert.Throws(Is.TypeOf<System.ArgumentOutOfRangeException>(), () => IntTools.Clamp(3, 5, 1));
        }

        [SetUp()]
        public void SetUp()
        {
            _resultOfClamp = new int();
        }

        #endregion Public Methods
    }
}