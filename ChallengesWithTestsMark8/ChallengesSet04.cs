using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            foreach (var i in numbers)
            {
                if (i % 2 == 0)
                {
                    result += i;
                }
                else {
                    result -= i;
                }

            }
            return result; 
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int len = int.MaxValue;
            foreach (var i in new string[] { str1, str2, str3, str4 }) 
            {
                if (i.Length < len)
                {
                    len = i.Length;
                }
            }
            return len;
            throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            
            int len = int.MaxValue;
            foreach (var i in new int[] { number1, number2, number3, number4 })
            {
                if (i < len)
                {
                    len = i;
                }
            }
            return len;
            throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
         
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int[] lengths = new int[] { sideLength1, sideLength2, sideLength3 };
            Array.Sort(lengths);
            if (lengths[0] <= 0) {
                return false;
            }
            return lengths[2] < (lengths[1] + lengths[0]);

            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            double i;
            bool isNumber = double.TryParse(input, out i);
            return isNumber;
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int length = 0;
            foreach (var i in objs)
            {
                if (i is null) {
                    nullCount++;
                }
                length++;      
            }
            return nullCount > length - nullCount;

            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers is null) {
                return 0;
            }
            double len = 0.0;
            double sum = 0.0;
            foreach (var i in numbers) {
                if (i % 2 == 0) {
                    len++;
                    sum += i;
                }       
            }
            if (len != 0)
            {
                return sum / len;
            }
            else 
            {
                return 0;
            }

                throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            if (number < 0) {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0) {
                return 1;
            }
            return number * Factorial(number - 1);
            
        }
    }
}
