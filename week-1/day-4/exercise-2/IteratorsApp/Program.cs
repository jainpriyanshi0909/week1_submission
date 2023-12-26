using System.Collections.Generic;

namespace IteratorsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input :");
            int n = int.Parse(Console.ReadLine());
            var fibonacci = FibonacciSequence(n).Take(10);
            foreach (int number in fibonacci)
            {
                Console.WriteLine(number);
            }
        }
        // https://www.c-sharpcorner.com/UploadFile/5ef30d/understanding-yield-return-in-C-Sharp/
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/yield
        public static IEnumerable<int> FibonacciSequence(int n)
        {  //solution one
            List<int> list = new List<int>();
            IEnumerable<int> numberList = list;
            int firstNo = 0;
            int secondNo = 1;
            list.Add(0);
            list.Add(1);
            for(int i =0;i<n-2;i++) {
                int thirdNo = secondNo + firstNo;
                list.Add(thirdNo);
                firstNo = secondNo;
                secondNo=thirdNo;
            }


            return numberList;
            //solution 2 using yield:
            /*
             *  int firstNo = 0;
            yield return firstNo;
            int secondNo = 1;
            yield return secondNo;
            for(int i =0;i<10;i++ ) {
                int thirdNo = secondNo + firstNo;
                firstNo = secondNo;
                secondNo=thirdNo;
                yield return thirdNo;
            }
             */
        }
    }
}