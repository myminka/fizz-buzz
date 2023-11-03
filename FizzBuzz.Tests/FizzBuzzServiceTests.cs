using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzServiceTests
    {
        private FizzBuzzGenerator _fizzBuzzGenerator;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzzGenerator = new FizzBuzzGenerator();
        }

        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(7, "Whizz")]
        [TestCase(11, "Bang")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(21, "FizzWhizz")]
        [TestCase(33, "FizzBang")]
        [TestCase(35, "BuzzWhizz")]
        [TestCase(55, "BuzzBang")]
        [TestCase(77, "WhizzBang")]
        [TestCase(105, "FizzBuzzWhizz")]
        [TestCase(1155, "FizzBuzzWhizzBang")]
        public void Test_FizzBuzzItem(int value, string expected)
        {
            string item = _fizzBuzzGenerator.GetFizzBuzzItem(value);
            Assert.AreEqual(expected, item);
        }
    }
}
