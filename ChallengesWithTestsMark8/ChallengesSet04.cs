using System;
using System.Linq;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {

            int result = numbers.Sum(number => number % 2 == 0 ? number : -number);
            return result;


        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {

            int minLength = new[] { str1.Length, str2.Length, str3.Length, str4.Length }.Min();
            return minLength;


        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = { number1, number2, number3, number4 };
            int smallestNumber = numbers.Min();
            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 &&
        sideLength1 + sideLength3 > sideLength2 &&
        sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }

            return false;
        }

        public bool IsStringANumber(string input)
        {
            return int.TryParse(input, out _) || double.TryParse(input, out _);

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = objs.Count(obj => obj == null);
            int nonNullCount = objs.Count(obj => obj != null);

            return nullCount > nonNullCount;
        }



        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            var evenNumbers = numbers.Where(num => num % 2 == 0);

            if (evenNumbers.Any())
            {
                double average = evenNumbers.Average();
                return average;
            }

            return 0;
        }


        public int Factorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

    }
}
