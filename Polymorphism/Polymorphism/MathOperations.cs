using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class MathOperations : IOperation
    {
        public int Add(int num1, int num2)
        {
            int num = num1 + num2;
            return num;
        }

        public double Add(double num1, double num2, double num3)
        {
            double num =
                num1 + num2 + num3;
            return num;
        }

        public decimal Add(decimal num1, decimal num2, decimal num3)
        {
            decimal num =
                num1 + num2 + num3;
            return num;
        }
    }
}
