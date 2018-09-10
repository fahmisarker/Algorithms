using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.StringHelpers
{
    public class StringUtility
    {
        //Tips: Anagrams can be found only on strings of equal length
        public static bool IsAnagramLowerCase(string a, string b) {

            if (a == null || b == null)
                return false;

            if (a.Length != b.Length)
                return false;

            int[] arr = new int[26];
           
            for (int i = 0; i < a.Length; i++) {
                arr[a[i] - 'a']++;     
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (arr[b[i] - 'a'] == 0)  
                    return false;    //the character frequency is unbalanced, so is not a anagram

                arr[b[i] - 'a']--;
            }

            return true;
        }

        //Conditions: 1. All chars are the same  2. All chars except the middle is the same
        public static bool IsSpecialPalindrome(string s) {
            if (s == null)
                return false;

            if (s.Length == 1)
                return true;
            char f = s[0];
            int midindex = -1;

            if (s.Length % 2 != 0) { //check mid point 
                midindex = s.Length / 2;
            }

            //if (midindex == -1)
            //{
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        if (s[i] != f)
            //            return false;
            //    }
            //}
            //else {
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        if (s[i] != f && i != midindex)
            //            return false;
            //    }
            //}
            return true;
        }
    }
}
