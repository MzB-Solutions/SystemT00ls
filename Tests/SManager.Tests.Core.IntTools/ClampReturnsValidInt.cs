using NUnit.Framework;
using static SManager.Core.IntTools;

namespace SManager.Tests.Core.IntTools
{
    [TestFixture]
    public class ClampReturnsValidInt
    {
        #region Public Properties

        public int ResultOfClamp { get; set; }

        #endregion Public Properties

        #region Public Methods

        [SetUp]
        public void SetUp()
        {
            ResultOfClamp = new int();
        }

        [Test]
        public void TestClampWithToBigValue()
        {
            ResultOfClamp = Clamp(12, 1, 5);
            Assert.AreEqual(ResultOfClamp, 5);
        }

        [Test]
        public void TestClampWithToSmallValue()
        {
            ResultOfClamp = Clamp(-1, 1, 5);
            Assert.AreEqual(ResultOfClamp, 1);
        }

        [Test]
        public void TestClampWithValidValue()
        {
            ResultOfClamp = Clamp(3, 1, 5);
            Assert.AreEqual(ResultOfClamp, 3);
        }

        #endregion Public Methods
    }
}