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

                // enter n
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());
                a = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter a[{0}]: ", i);
                    a[i] = int.Parse(Console.ReadLine());
                }
                //enter k
                Console.Write("Enter k: ");
                int k = int.Parse(Console.ReadLine());

                int s = 0;
                for (int i = 0; i < k; i++)
                {
                    s += a[i];
                }
                double avg = (double) s / k;
                Console.WriteLine("Average: {0}", avg);
            } catch (FormatException)
            {
                Console.WriteLine("Input is not a number!");
            } catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Number k is exceeds range of array!");
            } catch (DivideByZeroException)
            {
                Console.WriteLine("When divide, k cannot be zero!");
            }
        }
    }
}
