namespace FizzBuzz
{
    public class FizzBuzzGenerator : IFizzBuzzGenerator
    {
        private delegate string? FizzBuzzRule(int number);

        private readonly FizzBuzzRule fizzRule = number => (number % 3 == 0) ? DivisibleBy3 : null;
        private readonly FizzBuzzRule buzzRule = number => (number % 5 == 0) ? DivisibleBy5 : null;
        private readonly FizzBuzzRule whizzRule = number => (number % 7 == 0) ? DivisibleBy7 : null;
        private readonly FizzBuzzRule bangRule = number => (number % 11 == 0) ? DivisibleBy11 : null;

        public static string DivisibleBy3 { get; set; } = "Fizz";
        public static string DivisibleBy5 { get; set; } = "Buzz";
        public static string DivisibleBy7 { get; set; } = "Whizz";
        public static string DivisibleBy11 { get; set; } = "Bang";

        public string GetFizzBuzzItem(int number)
        {
            string result = fizzRule(number) + buzzRule(number) + whizzRule(number) + bangRule(number);
            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }
    }
}
