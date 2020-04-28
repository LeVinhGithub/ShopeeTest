using NUnit.Framework;

namespace Shopee
{
    class TestBase
    {
        [SetUp]
        public void StartTest()
        {
            Common.StartDriver();
        }

        [TearDown]
        public void FinishTest()
        {
            Common.Finish_driver();
        }
    }
}
