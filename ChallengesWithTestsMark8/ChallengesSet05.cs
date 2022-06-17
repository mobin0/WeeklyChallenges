using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int number = startNumber + 1;
            while (true) {
                if (number % n == 0) {
                    return number;
                }
                number++;
            }
            throw new NotImplementedException();
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business biz in businesses)
            {
                if (biz.TotalRevenue <= 0)
                {
                    biz.Name = "CLOSED";
                }
            }
            //throw new NotImplementedException();
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers is null || numbers.Length == 0) {
                return false;
            }
            int last = numbers[0];
            bool first = true;
            foreach (int num in numbers) {
                if (first) {
                    first = false;
                    continue;
                }
                if (num >= last)
                {
                    last = num;
                }
                else
                {
                    return false;
                }

            }
            return true;

            throw new NotImplementedException();
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers is null || numbers.Length == 0) {
                return 0;
            }
            bool even = false;
            int sum = 0;
            bool first = true;
            foreach (var num in numbers) {
                if (num % 2 == 0 && first) {
                    even = true;
                    first = false;
                    continue;
                }
                if (even) {
                    sum += num;
                }
                even = (num % 2 == 0);


            }
            return sum;
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words is null || words.Length == 0) {
                return "";
            }
            List<string> results = new List<string>();
            for (int x = 0; x < words.Length; x++)
            {
                string trimmedWord = String.Concat(
                    words[x].ToCharArray()
                    .Where(c => !Char.IsWhiteSpace(c))
                    .ToArray()
                );
                if (!string.IsNullOrEmpty(trimmedWord)) {
                    results.Add(trimmedWord);
                }


            }
            string resultString = string.Join(" ", results.ToArray());
            if (!string.IsNullOrEmpty(resultString)) {
                return resultString + '.';
            }


            return resultString;

            throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            int i = 1;
            bool first = true;
            if (elements is null || elements.Count == 0) {
                double[] emptyArray = {};
                return emptyArray;
            }
            List<double> results = new List<double>();
            foreach (var element in elements)
            {
              
                if (first)
                {
                    first = false;
    
                }
                else
                {
                    if (i % 4 == 0)
                    {
                        results.Add(element);
                    }


                }
                i++;
            }
            return results.ToArray();
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length; i++) {
                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[i] + nums[j] == targetNumber) {
                        return true;
                    }
                
                }
            }
            return false;
            throw new NotImplementedException();
        }
    }
}
