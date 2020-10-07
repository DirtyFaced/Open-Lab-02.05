using System;

namespace Open_Lab_02._05
{
    public class Calculator
    {
        public bool DivisibleByFive(int number)
        {
            bool je;
            je = false;
            if (number % 5 == 0)
            { je = true; };
            return je;
        }
    }
}
