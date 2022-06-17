using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words is null || words.Count() == 0)
            {
                return false;
            }

            if (ignoreCase)
            {
                foreach (string w in words) {
                    if (w is null) {
                        continue;
                    }
                    if (w.ToLower() == word) {
                        return true;
                    }

                }
            }
            else
            {

                foreach (string w in words)
                {
                    if (w is null)
                    {
                        continue;
                    }

                    if (w == word)
                    {
                        return true;
                    }
                }

            }
            return false;
            throw new NotImplementedException();
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) {
                return false;
            }
            for (int i = 2; i < num; i++) {
                if (num % i == 0) {
                    return false;
                }
            }
            return true;
            throw new NotImplementedException();
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str.Length == 1) {
                return 0;
            }
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversed = String.Concat(charArray);
            bool found = false;
            List<char> foundLetter = new List<char>();
            for (int x = 0; x < reversed.Length; x++)
            {
                found = false;

                for (int y = x + 1; y < reversed.Length; y++)
                {
                    if (foundLetter.Contains(reversed[x]))
                    {
                        continue;
                    }

                    if (reversed[x] == reversed[y])
                    {
                        found = true;
                    }

                    if (found)
                    {
                        foundLetter.Add(reversed[x]);
                        found = false;
                        continue;
                    }
                }
                    if (!foundLetter.Contains(reversed[x]))
                    {
                        return reversed.Length - x - 1;
                    }
                
            }
                return -1;
            
            //            char[] charArray = str.ToCharArray();
            //Array.Reverse(charArray);
            //string reversed = String.Concat(charArray);

            //List<char> charList = new List<char>();
            //int index = -1;
            //int count = 0;

            //for (int i = 0; i < charList.Count; i++)
            //{
            //    if (!charList.Contains(str[i]))
            //    {
            //        charList.Add(str[i]);
            //        str.Replace(str[i], ' '); ;
            //        index = i;
            //    }
            //    else {



            //    }

            //}
            //return index;
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int number;
            int count;
            int maxCount = 0;
            for (int x = 0; x < numbers.Length; x++)
            {
                number = numbers[x];
                count = 1;
                for (int y = x + 1; y < numbers.Length; y++)
                {
                    if (numbers[y] == number)
                    {
                        count += 1;


                    }
                    else
                    {


                        break;


                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    count = 1;


                }

            }


            
            return maxCount;
            //Dictionary<int, int> counts = new Dictionary<int, int>();
            //int lastNum = int.MaxValue;
            //int count = 1;
            //bool first = true;
            //foreach (int num in numbers)
            //{
            //    if (first)
            //    {
            //        counts[num] = 1;
            //        lastNum = num;
            //        first = false;

            //        continue;

            //    }
            //    if (lastNum == num)
            //    {
            //        count += 1;

            //    }
            //    else
            //    {

            //        counts[lastNum] = count;
            //        count = 1;
            //    }
            //    lastNum = num;
            //}

            //int max = int.MinValue;
            //foreach (int num2 in counts.Keys)
            //{
            //    if (counts[num2] > max)
            //    {
            //        max = counts[num2];
            //    }
            //}

            //return max;
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements is null || elements.Count == 0) {
                return new double[0]; 
            }
            if (n < 0) {
                return new double[0];
            }
            List<double> result = new List<double>();
            for (int x = 0; x <= elements.Count; x += (n)) {
                if (x == 0 && n != 1)
                {
                    continue;
                }
                if (x == 0 && n == 1) {
                    result.Add(elements[0]);
                    continue;
                }

                if (x - 1 < elements.Count && x - 1 != 0)
                {
                    result.Add(elements[x - 1]);
                }
            }
            return result.ToArray();
            throw new NotImplementedException();
        }
    }
}
