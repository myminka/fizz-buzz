namespace FizzBuzz
{
    public class FizzBuzzService
    {
        private FizzBuzzParameters _fizzBuzzParameters;

        public FizzBuzzService()
        {
            _fizzBuzzParameters = new FizzBuzzParameters();
        }

        public FizzBuzzService(FizzBuzzParameters parameters)
        {
            _fizzBuzzParameters = parameters;
        }

        public List<string> GetSequence(int from, int till)
        {
            var sequence = new List<string>();
            for (int i = from; i <= till; i++)
            {
                var item = GetItem(i);
                sequence.Add(item);
            }

            return sequence;
        }

        public string GetItem(int number)
        {
            var result = string.Empty;

            if (number % 3 == 0)
                result += _fizzBuzzParameters.DivisibleByThree;
            
            if (number % 5 == 0)
                result += _fizzBuzzParameters.DivisibleByFive;
            
            if (number % 7 == 0)
                result += _fizzBuzzParameters.DivisibleBySeven;
            
            if (result.Length == 0)
                result += number.ToString();

            return result;
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

        public FizzBuzzParameters FizzBuzzParameters 
        {
            get
            {
                return new FizzBuzzParameters
                {
                    DivisibleByThree = _fizzBuzzParameters.DivisibleByThree,
                    DivisibleByFive = _fizzBuzzParameters.DivisibleByFive,
                    DivisibleBySeven = _fizzBuzzParameters.DivisibleBySeven
                };
            }
            set
            {
                if (value is null)
                    throw new ArgumentNullException();

                _fizzBuzzParameters = value;
            }
        }
    }
}
