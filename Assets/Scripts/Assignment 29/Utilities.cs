using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public static string RepeatString(this string str, int times)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                result.Append(str);
            }
            return result.ToString();
        }
    }
}
