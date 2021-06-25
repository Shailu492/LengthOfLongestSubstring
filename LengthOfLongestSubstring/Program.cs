using System;
using System.Collections.Generic;

namespace LengthOfLongestSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = LongestSubstring("gaaqfeqlqky");
            Console.WriteLine("Hello World!");
        }

        public static int LongestSubstring(string s)
        {
            if (s.Length == 0) return 0;

            int result = 0;
            int position = 0;
            HashSet<char> set = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (set.Contains(s[i]))
                {
                    result = Math.Max(result, set.Count);

                    for (int j = position; j < i; j++)
                    {
                        set.Remove(s[position]);
                        position++;

                        if (!set.Contains(s[i])) break;
                    }
                }

                set.Add(s[i]);
            }

            result = Math.Max(result, set.Count);
            return result;
        }

        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;

            int result = 0;
            int counter = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i-1] == s[i])
                {
                    result = Math.Max(result, counter);
                    counter = 1;
                    continue;
                }

                counter++;
            }

            result = Math.Max(result, counter);
            return result;
        }
    }
}
