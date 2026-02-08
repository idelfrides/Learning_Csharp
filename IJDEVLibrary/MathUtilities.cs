using System;
using System.Linq;


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

    public class MathUtils
    {
         // Median → Not provided by LINQ or Array.You need to implement it manually:
        public static double Median(int[] numbers)
        {
            var sorted = numbers.OrderBy(n => n).ToArray();
            int size = sorted.Length;
            int mid = size / 2;

            if (size % 2 == 0)
                return (sorted[mid - 1] + sorted[mid]) / 2.0;
            else
                return sorted[mid];
        }

        //- Standard Deviation → Also not built-in. You can implement it:

        public static double StandardDeviation(int[] numbers)
        {
            double avg = numbers.Average();
            double sumOfSquares = numbers.Select(n => Math.Pow(n - avg, 2)).Sum();
            return Math.Sqrt(sumOfSquares / numbers.Length);
        }

        // Mean → Built-in with LINQ
        public static double Mean(int[] numbers)
        {
            return numbers.Average();
        }
    }

}