using System;

namespace SumMethod
{
    public static class Program
    {
        public static void Main()
        {
            int sum = SumMethod(100);
            Console.WriteLine("The sum is -- " + sum);

            Console.ReadLine();
        }

        // TODO: Create a method that returns the sum of all integer numbers up to and including given value. 
        // Use the equation (n * (n + 1)) / 2.

        private static int SumMethod(int n)
        {
            int sum = (n * (n + 1)) / 2;

            return sum;

        }
    }
}
