using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.StringHelpers
{
    public static class PalindromeUtility
    {
        // Utility method to check if substring from low to high is
        // palindrome or not.
        public static bool IsPalindrome(string s, int low, int high)
        {
            while (low < high)
            {
                if (s[low] != s[high])
                    return false;
                low++;
                high--;
            }
            return true;
        }

    }
}
