using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {

        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals is null || vals.Length == 0) {
                return false;
            }
            foreach (bool val in vals) {
                if (val is false) {
                    return true;
                }
            
            }
            return false;
            throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int calculation = 0;
     
            if (numbers == null || numbers.Count() == 0) {
                return false;
            }
            foreach (int i in numbers)
            {
                if (i % 2 != 0) {
                    calculation += i;
                
                }

            }
            return calculation % 2 != 0;
            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool number = false;
            foreach (char i in password)
            {
                if (Char.IsUpper(i)) {
                    upper = true;
                }
                if (Char.IsLower(i)) {
                    lower = true;
                }
                if (Char.IsNumber(i))
                {
                    number = true;

                }
              


            }
            return (upper && lower && number);
            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            //foreach (char i in val) {
            //    if (Char.IsLetter(i)) {
            //        return i;
            //    }
            //}
            //return '0';
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char[] d = val.ToCharArray();
            Array.Reverse(d);
            return GetFirstLetterOfString(String.Concat(d));

                
           
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {

            if (divisor == 0) {
                return 0;
            }
            return dividend / divisor;
          
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums is null)
            {
                return 0;
            }
            return nums[nums.Length - 1] - nums[0];
            throw new NotImplementedException();

        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for (int i = 0; i < 100; i++) {
                if (i % 2 != 0) {
                    odds.Add(i);
                }
            }
            return odds.ToArray();
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int x = 0; x < words.Length; x++)
            {
                words[x] = words[x].ToUpper();
            }

            //throw new NotImplementedException();
        }
    }
}
