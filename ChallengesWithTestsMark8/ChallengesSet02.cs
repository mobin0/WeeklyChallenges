using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
            throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals is null)
            {
                return false;
            }
            int size = vals.Length;
            return size % 2 == 0;
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
            throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {

            return num % 2 != 0;
            throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers is null)
            {
                return 0;
            }
            double max = double.MinValue;
            double min = double.MaxValue;
            foreach (double i in numbers) {
                if (i > max) {
                    max = i;
                }
                if (i < min) {
                    min = i;
                }
            }
            return max + min;

            
            
            
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length = str1.Length;
            int length2 = str2.Length;
            return length > length2 ? length2 : (length2 == length) ? length : length; 
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            if (numbers is null) {
                return 0;
            }
            int result = 0;
            foreach (int i in numbers) {
                result += i;
            
            }
            return result;
            throw new NotImplementedException();
        }
       
        public int SumEvens(int[] numbers)
        {
            if (numbers is null)
            {
                return 0;
            }
            int result = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0) {
                    result += i;
                }
            }
            return result;
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers is null) {
                return false;
            }
            return Sum(numbers.ToArray()) % 2 != 0;

            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        { int result = 0;
            for (long i = number - 1; i > 0; i--) {

                if (i % 2 != 0) {
                    result += 1;
                }
            }
            return result;
            
            throw new NotImplementedException();
        }
        
    }

}
