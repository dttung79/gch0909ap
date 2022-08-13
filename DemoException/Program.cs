using System;

namespace DemoException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // declare 1 array a
                int []a = {};

                int n = GetInteger("Enter n: ");
                a = new int[n];

                for (int i = 0; i < n; i++)
                {
                    a[i] = GetInteger("Enter a[" + i + "]: ");
                }

                int k = GetInteger("Enter k: ");
                int s = 0;
                for (int i = 0; i < k; i++)
                {
                    s += a[i];
                }
                double avg = (double) s / k;
                Console.WriteLine("Average: {0}", avg);
            } 
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Number k is exceeds range of array!");
            } catch (DivideByZeroException)
            {
                Console.WriteLine("When divide, k cannot be zero!");
            }
        }
        static int GetInteger(string message)
        {
            bool invalid = true;
            int number = 0;
            while (invalid)
            {
                Console.Write(message);
                try 
                {
                    number = int.Parse(Console.ReadLine());
                    invalid = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Must be integer!");
                }
            }
            return number;
        }
    }
}
