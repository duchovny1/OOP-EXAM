using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public interface IOperation
    {
        int Add(int num1, int num2);
        double Add(double num1, double num2, double num3);
        decimal Add(decimal num1, decimal num2, decimal num3);

    }
}
