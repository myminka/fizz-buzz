namespace FizzBuzz
{
    public class FizzBuzzService
    {
        private readonly IFizzBuzzGenerator _fizzBuzzGenerator;

        public FizzBuzzService(IFizzBuzzGenerator fizzBuzzGenerator)
        {
            _fizzBuzzGenerator = fizzBuzzGenerator ?? throw new ArgumentNullException();
        }

        public List<string> GetSequence(int from, int till)
        {
            var sequence = new List<string>();
            for (int i = from; i <= till; i++)
            {
                var item = _fizzBuzzGenerator.GetFizzBuzzItem(i);
                sequence.Add(item);
            }
            return sequence;
        }

        public void PrintSequence(List<string> sequence)
        {
            foreach (var item in sequence)
                Console.WriteLine(item);
        }
    }
}
