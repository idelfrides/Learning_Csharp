using System;

namespace IJDEVLibrary
{

    // Basic arithmetic operations
    public class Calculator
    {
        public int Add(params int[] values)
        {
            if (values.Length == 0) throw new ArgumentException("No values provided.");

            int sum = 0;
            foreach (int val in values)
            {
                sum += val;
            }
            return sum;
        }

        public int Subtract(params int[] values)
        {
            if (values.Length == 0) throw new ArgumentException("No values provided.");

            int result = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                result -= values[i];
            }
            return result;
        }

        public int Multiply(params int[] values)
        {
            if (values.Length == 0) throw new ArgumentException("No values provided.");

            int product = 1;
            foreach (int val in values)
            {
                product *= val;
            }
            return product;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return (double)a / b;
        }
    }

    // Trigonometry operations
    public class ManageTrigonometryOperations
    {
        public double CalculateSine(double angleInRadians)
        {
            return Math.Sin(angleInRadians);
        }

        public double CalculateCosine(double angleInRadians)
        {
            return Math.Cos(angleInRadians);
        }

        public double CalculateTangent(double angleInRadians)
        {
            return Math.Tan(angleInRadians);
        }
    }
    
}