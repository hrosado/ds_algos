using System;
using System.Collections.Generic;

namespace _01_Console_Big_O
{
    class Program
    {
        static void Main(string[] args)
        {
            // O(n^2)

        }
        // O(1) - performance is constant
        void Function_01(List<string> data)
        {
            string str = data[0];
        }
        // O(n) - linear, performance will degrade
        // or the time required for processing will
        // increase linearly
        void Function_02(List<string> data)
        {
            foreach (string str in data)
            {
                if(str == "foo")
                {
                    return;
                }
            }
        }

        // O(2n) or O(n^2) is also a possibility
        // Quadratic
        void Function_03(List<string> data)
        {
            foreach (string str in data)
            {
                foreach (string str1 in data)
                {
                    return;
                }
            }
        }
    }
}
