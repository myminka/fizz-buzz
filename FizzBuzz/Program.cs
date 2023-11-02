namespace FizzBuzz
{
    public class Program
    {
        static void Main()
        {
            var service = new FizzBuzzService();
            var sequence = service.GetSequence();
            service.PrintSequence(sequence);
        }
    }
}
