using System;
using System.Linq;

namespace ConsoleApp1
{
    class Solution
    {
        public void helper(char[] s, int left, int right)
        {
            if (left >= right) return;
            char tmp = s[left];
            s[left++] = s[right];
            s[right--] = tmp;
            helper(s, left, right);
        }

        public void reverseString(char[] s)
        {
            helper(s, 0, s.Length - 1);
        }

    }


}
