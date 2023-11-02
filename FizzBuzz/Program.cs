namespace FizzBuzz
{
    public class Program
    {
        static void Main()
        {
            var service = new FizzBuzzService();
            var result = service.GetResult();
            service.PrintResult(result);
        }
    }
}
