using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static double Maximum(double[] doubleArray)
        {
            int i;
            double maxDouble;
            maxDouble = doubleArray[0];
            for (i = 0; i < doubleArray.Length; i = i + 1)
            {
                if (doubleArray[i] > maxDouble)
                {
                    maxDouble = doubleArray[i];
                }
            }
            return maxDouble;
        }

        public static double Add(double v1, double v2)
        {
            throw new NotImplementedException();
        }

        public static double Subtract(double v1, double v2)
        {
            throw new NotImplementedException();
        }

        public static double Minimum(double[] numbers)
        {
            int i;
            double minInts;
                minInts = numbers[0];
                for (i = 0; i < numbers.Length; i = i + 1)
                {
                    if (numbers[i] < minInts)
                    {
                        minInts = numbers[i];
                    }
                }
                return minInts;
        }

        public static double Divide(double v1, double v2)
        {
            throw new NotImplementedException();
        }

        public static double Sum(double[] numbers)
        {
            throw new NotImplementedException();
        }

        public static double Multiply(double v1, double v2)
        {
            throw new NotImplementedException();
        }

        public static double Average(double[] numbers)
        {
            throw new NotImplementedException();
        }
    }
}
