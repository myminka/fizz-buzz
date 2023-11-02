namespace FizzBuzz
{
    public class FizzBuzzService
    {
        public List<string> GetSequence()
        {
            var sequence = new List<string>();
            for (int i = 1; i <= 100; i++)
            {
                var item = GetItem(i);
                sequence.Add(item);
            }
            return sequence;
        }

        public string GetItem(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
                return "FizzBuzz";
            else if (i % 3 == 0)
                return "Fizz";
            else if (i % 5 == 0)
                return "Buzz";
            return i.ToString();
        }

        public void PrintSequence(List<string> sequence)
        {
            if (!sequence.Any())
                Console.WriteLine("There is no items in the list");
            else
            {
                foreach (var item in sequence)
                    Console.WriteLine(item);
            }
        }
    }
}
