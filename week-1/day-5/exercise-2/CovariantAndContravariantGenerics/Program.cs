namespace CovariantAndContravariantGenerics
{
    interface IProcessor<in TInput, out TResult>
    {
        TResult Process(TInput input);
    }

    class StringToIntProcessor : IProcessor<string, int>
    {
        // Implement Process method
        public int Process(string input)
        { /*
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input string is null or empty.");
            }

            int result = 0;
            int sign = 1;

            // Check for negative sign
            if (input[0] == '-')
            {
                sign = -1;
                input = input.Substring(1); // Remove the negative sign
            }

            // Convert each digit to int
            foreach (char digitChar in input)
            {
                if (char.IsDigit(digitChar))
                {
                    int digitValue = digitChar - '0'; // Convert char to int
                    result = result * 10 + digitValue;
                }
                else
                {
                    throw new ArgumentException($"Invalid character in input: {digitChar}");
                }
            }

            return result * sign;
            */
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("not getting result");
                return 0;
            }
        }
    }

    class DoubleToStringProcessor : IProcessor<double, string>
    {
        // Implement Process method
        public string Process(double input)
        {
           string ans =input.ToString();
            return ans;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {   
            string StringToNo = "123";
            double DoubleToString = 3.11;
            IProcessor<string,int> Processor = new StringToIntProcessor();
            IProcessor<double,string> Processor2 = new DoubleToStringProcessor();
            int ans1 = Processor.Process(StringToNo);
            string ans2 = Processor2.Process(DoubleToString);
            Console.WriteLine(ans1);
            Console.WriteLine(ans2);           


            // Demonstrate covariance and contravariance with IProcessor interface
        }
    }
}