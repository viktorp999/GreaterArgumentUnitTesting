﻿
namespace GreaterArgument
{
    public class MaxArgument
    {
        public int Max(int num1, int num2)
        {
            if (num1 > num2 || num1 == num2)
            {
                return num1;
            }

            return num2;
        }
    }
}
