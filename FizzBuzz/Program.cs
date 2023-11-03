namespace FizzBuzz
{
    public class Program
    {
        static void Main()
        {
            var service = new FizzBuzzService();
            service.FizzBuzzParameters = new FizzBuzzParameters()
            {
                DivisibleByThree = "333",
                DivisibleByFive = "555",
                DivisibleBySeven = "777",
            };

            var sequence = service.GetSequence(1, 100);
            service.PrintSequence(sequence);
        }
    }
}
