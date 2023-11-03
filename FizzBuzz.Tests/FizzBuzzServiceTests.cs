using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzServiceTests
    {
        private FizzBuzzService _fizzBuzzService;
        private FizzBuzzService _customFizzBuzzService;
        private readonly List<string> _fizzBuzzSequenceCorrect = new()
        {
"1",
"2",
"Fizz",
"4",
"Buzz",
"Fizz",
"7",
"8",
"Fizz",
"Buzz",
"11",
"Fizz",
"13",
"14",
"FizzBuzz",
"16",
"17",
"Fizz",
"19",
"Buzz",
"Fizz",
"22",
"23",
"Fizz",
"Buzz",
"26",
"Fizz",
"28",
"29",
"FizzBuzz",
"31",
"32",
"Fizz",
"34",
"Buzz",
"Fizz",
"37",
"38",
"Fizz",
"Buzz",
"41",
"Fizz",
"43",
"44",
"FizzBuzz",
"46",
"47",
"Fizz",
"49",
"Buzz",
"Fizz",
"52",
"53",
"Fizz",
"Buzz",
"56",
"Fizz",
"58",
"59",
"FizzBuzz",
"61",
"62",
"Fizz",
"64",
"Buzz",
"Fizz",
"67",
"68",
"Fizz",
"Buzz",
"71",
"Fizz",
"73",
"74",
"FizzBuzz",
"76",
"77",
"Fizz",
"79",
"Buzz",
"Fizz",
"82",
"83",
"Fizz",
"Buzz",
"86",
"Fizz",
"88",
"89",
"FizzBuzz",
"91",
"92",
"Fizz",
"94",
"Buzz",
"Fizz",
"97",
"98",
"Fizz",
"Buzz"
        };

        [SetUp]
        public void SetUp()
        {
            var parameters = new FizzBuzzParameters()
            {
                DivisibleByThree = "Alt+Enter",
                DivisibleByFive = "You are honey",
                DivisibleBySeven = "Civilization 5 is the best game of the world!!!"
            };

            _fizzBuzzService = new FizzBuzzService();
            _customFizzBuzzService = new FizzBuzzService(parameters);
        }

        [TestCase(1)]
        public void TestForRegularItem(int value)
        {
            var item = _customFizzBuzzService.GetItem(value);

            Assert.AreEqual(item, value.ToString());
        }

        [TestCase(3)]
        public void TestForDivisibleByThree(int value)
        {
            var item = _customFizzBuzzService.GetItem(value);

            Assert.AreEqual(item, _customFizzBuzzService.FizzBuzzParameters.DivisibleByThree);
        }

        [TestCase(5)]
        public void TestForDivisibleByFive(int value)
        {
            var item = _customFizzBuzzService.GetItem(value);

            Assert.AreEqual(item, _customFizzBuzzService.FizzBuzzParameters.DivisibleByFive);
        }

        [TestCase(7)]
        public void TestForDivisibleBySeven(int value)
        {
            var item = _customFizzBuzzService.GetItem(value);

            Assert.AreEqual(item, _customFizzBuzzService.FizzBuzzParameters.DivisibleBySeven);
        }

        [TestCase(15)]
        public void TestForFizzDivisibleByThreeAndFive(int value)
        {
            var item = _customFizzBuzzService.GetItem(value);

            Assert.AreEqual(item, $"{_customFizzBuzzService.FizzBuzzParameters.DivisibleByThree}{_customFizzBuzzService.FizzBuzzParameters.DivisibleByFive}");
        }

        [TestCase(210)]
        public void TestForDivisibleByTwoHundredAndTen(int value)
        {
            var item = _customFizzBuzzService.GetItem(value);
            var expectedResult = $"{_customFizzBuzzService.FizzBuzzParameters.DivisibleByThree}" +
                $"{_customFizzBuzzService.FizzBuzzParameters.DivisibleByFive}" +
                $"{_customFizzBuzzService.FizzBuzzParameters.DivisibleBySeven}";

            Assert.AreEqual(item, expectedResult);
        }
    }
}
