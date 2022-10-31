using NUnit.Framework;

namespace GreaterArgument.UnitTests
{
    [TestFixture]
    public class MaxArgumentTests
    {
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
        {
            MaxArgument max = new MaxArgument();

            int result = max.Max(a,b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
