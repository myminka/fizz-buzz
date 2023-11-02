namespace FizzBuzz
{
    public class FizzBuzzService
    {
        public List<string> GetResult()
        {
            var result = new List<string>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result.Add("FizzBuzz");
                else if (i % 3 == 0)
                    result.Add("Fizz");
                else if (i % 5 == 0)
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());
            }
            return result;
        }

        public void PrintResult(List<string> result)
        {
            foreach (var item in result)
                Console.WriteLine(item);
        }
    }
}
