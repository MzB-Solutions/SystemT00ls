using NUnit.Framework;

namespace SManager.Tests.Core.IntTools
{
    public class ClampReturnsNonNull
    {
        #region Public Methods

        [Test]
        public void TestClampWithValidValue()
        {
            int result = SManager.Core.IntTools.Clamp(4, 1, 5);
            Assert.IsNotNull(result);
        }

        #endregion Public Methods
    }
}