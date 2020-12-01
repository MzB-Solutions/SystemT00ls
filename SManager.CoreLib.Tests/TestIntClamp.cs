using NUnit.Framework;

namespace SManager.CoreLib.Tests
{
    [TestFixture]
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        #region Public Methods

        [Test]
        public void Test1()
        {
            int result = IntTools.Clamp(4, 1, 5);
            Assert.IsNotNull(result);
        }

        #endregion Public Methods
    }
}