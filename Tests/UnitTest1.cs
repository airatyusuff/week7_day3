using week7_day3;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DummyIO_Should_Return()
        {
            var gio = new DummyInputOutput();
            string val = gio.GetInput();

            Assert.IsTrue(val == "23");
        }
    }
}