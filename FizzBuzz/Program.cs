namespace FizzBuzz
{
    public class Program
    {
        static void Main()
        {
            var fizzBuzzService = new FizzBuzzService(new FizzBuzzGenerator());
            var sequence = fizzBuzzService.GetSequence(1, 100);
            fizzBuzzService.PrintSequence(sequence);
        }
    }
}
